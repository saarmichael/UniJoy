using Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniJoy
{
    /// <summary>
    /// This class attempt to create from all the given variables , the static vector values.
    /// </summary>
    class StaticValuesGenerator
    {
        #region ATTRIBUTES
        /// <summary>
        /// The variables readen from the xlsx protocol file.
        /// </summary>
        private Variables _variablesList;

        /// <summary>
        /// The static variables list in double value presentation.
        /// The string is for the variable name.
        /// </summary>
        public Dictionary<string, List<double>> _staticVariableList;
        #endregion ATTRIBUTES

        #region CONSTRUCTORS
        /// <summary>
        /// Default constructor.
        /// </summary>
        public StaticValuesGenerator()
        {
        }
        #endregion CONSTRUCTORS

        #region FUNCTIONS
        /// <summary>
        /// Sets the total variables of all types readen from the xlsx file.
        /// </summary>
        /// <param name="variableList"></param>
        public void SetVariables(Variables variableList)
        {
            _variablesList = variableList;
            CreateDoubleStaticVariablesList();
        }

        /// <summary>
        /// Create the static variable list with list presentation instead of strings.
        /// </summary>
        private void CreateDoubleStaticVariablesList()
        {
            //initialize the dictionary.
            _staticVariableList = new Dictionary<string, List<double>>();

            foreach (string varName in _variablesList._variablesDictionary.Keys)
            {
                //if the variable is static type or const type , add it to the static variables list with it's attributes.
                if (_variablesList._variablesDictionary[varName]._description["status"].MoogParameter.Equals("1")
                    || _variablesList._variablesDictionary[varName]._description["status"].MoogParameter.Equals("0"))
                {
                    //it's static variable , so need to take only it's parameters value to the experiment round.
                    _staticVariableList.Add(varName, GetDoubleListFromString(_variablesList._variablesDictionary[varName]._description["parameters"].MoogParameter));
                }
            }
        }

        private List<double> GetDoubleListFromString(string str)
        {
            //remove redundant (duplicated ' ')
            for(int i=1;i<str.Length;i++)
            {
                if(str[i] == ' ' && str[i] == str[i-1])
                {
                    str.Remove(i);
                }
            }

            List<double> doubleList = new List<double>();

            //split by the ' '
            foreach (string stringDoublePresentation in str.Split(new char[] { ' ' }))
            {
                doubleList.Add(double.Parse(stringDoublePresentation));
            }

            return doubleList;
        }
        #endregion FUNCTIONS
    }
}
