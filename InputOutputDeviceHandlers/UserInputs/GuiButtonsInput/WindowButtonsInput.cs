using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace InputOutputDeviceHandlers.UserInputs.GuiButtonsInput
{
    public class WindowButtonsInput:IUserInputController
    {
        Form _responseForm;
        Button _startButtom;
        Button _rightButtom;
        Button _leftButtom;
        Button _downButttom;
        Button _upButtom;

        public WindowButtonsInput()
        {
            _responseForm = new Form();
            _responseForm.SizeChanged += _responseForm_SizeChanged;

            AddPressButtoms();
            _responseForm.Show();
        }

        private void _responseForm_SizeChanged(object sender, EventArgs e)
        {
            ChangePressButtonsLocations();
        }

        private void AddPressButtoms()
        {
             _startButtom = new Button();
            _startButtom.Text = "Start";
            _startButtom.Click += StartButton_Click;
            _responseForm.Controls.Add(_startButtom);

             _rightButtom = new Button();
            _rightButtom.Text = "Right";
            _rightButtom.Click += RightButtom_Click;
            _responseForm.Controls.Add(_rightButtom);

             _leftButtom = new Button();
            _leftButtom.Text = "Left";
            _leftButtom.Click += LeftButtom_Click;
            _responseForm.Controls.Add(_leftButtom);

             _downButttom = new Button();
            _downButttom.Text = "Down";
            _downButttom.Click += DownButttom_Click;
            _responseForm.Controls.Add(_downButttom);

             _upButtom = new Button();
            _upButtom.Text = "Up";
            _upButtom.Click += UpButtom_Click;
            _responseForm.Controls.Add(_upButtom);

            ChangePressButtonsLocations();

        }

        private void ChangePressButtonsLocations()
        {
            _startButtom.Location = new System.Drawing.Point(_responseForm.ClientSize.Width / 2 - _startButtom.Size.Width/2, _responseForm.ClientSize.Height / 2);
            _rightButtom.Location = new System.Drawing.Point(_responseForm.ClientSize.Width - _rightButtom.Size.Width, _responseForm.ClientSize.Height / 2);
            _leftButtom.Location = new System.Drawing.Point(0, _responseForm.ClientSize.Height / 2);
            _downButttom.Location = new System.Drawing.Point(_responseForm.ClientSize.Width / 2 - _downButttom.Size.Width/2, _responseForm.ClientSize.Height-_downButttom.Size.Height);
            _upButtom.Location = new System.Drawing.Point(_responseForm.ClientSize.Width / 2 - _upButtom.Size.Width/2, 0);
        }

        private void UpButtom_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DownButttom_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LeftButtom_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RightButtom_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void FlushBuffer()
        {
            throw new NotImplementedException();
        }

        public bool IsStartButtonPressed()
        {
            throw new NotImplementedException();
        }

        public bool LoadButtonsMapping()
        {
            throw new NotImplementedException();
        }

        public byte SubjectChoice()
        {
            throw new NotImplementedException();
        }
    }
}
