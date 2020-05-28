using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InputOutputDeviceHandlers.UserInputs.GuiButtonsInput
{
    public partial class WindowButtonsInput:IUserInputController
    {
        private ConcurrentQueue<PressType> _pressesQueue;

        public WindowButtonsInput()
        {
            _responseForm = new Form();
            _responseForm.SizeChanged += _responseForm_SizeChanged;

            _pressesQueue = new ConcurrentQueue<PressType>();

            AddPressButtoms();
            _responseForm.Show();
        }

        public void FlushBuffer()
        {
            while (_pressesQueue.TryDequeue(out _))
            {

            }
           
        }

        public bool IsStartButtonPressed()
        {
            PressType pressType;
            while (_pressesQueue.TryDequeue(out pressType) && pressType!=PressType.Start)
            {

            }

            return pressType == PressType.Start;
        }

        public bool LoadButtonsMapping()
        {
            throw new NotImplementedException();
        }

        public PressType SubjectChoice()
        {
            PressType pressType = PressType.None;
            _pressesQueue.TryDequeue(out pressType);

            return pressType;
        }
    }

    //partial class for the gui events and gui initializations.
    partial class WindowButtonsInput
    {

        Form _responseForm;
        Button _startButtom;
        Button _rightButtom;
        Button _leftButtom;
        Button _downButttom;
        Button _upButtom;

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
            _startButtom.Location = new Point(_responseForm.ClientSize.Width / 2 - _startButtom.Size.Width / 2, _responseForm.ClientSize.Height / 2);
            _rightButtom.Location = new Point(_responseForm.ClientSize.Width - _rightButtom.Size.Width, _responseForm.ClientSize.Height / 2);
            _leftButtom.Location = new Point(0, _responseForm.ClientSize.Height / 2);
            _downButttom.Location = new Point(_responseForm.ClientSize.Width / 2 - _downButttom.Size.Width / 2, _responseForm.ClientSize.Height - _downButttom.Size.Height);
            _upButtom.Location = new Point(_responseForm.ClientSize.Width / 2 - _upButtom.Size.Width / 2, 0);
        }

        private void UpButtom_Click(object sender, EventArgs e)
        {
            _pressesQueue.Enqueue(PressType.Up);
        }

        private void DownButttom_Click(object sender, EventArgs e)
        {
            _pressesQueue.Enqueue(PressType.Down);
        }

        private void LeftButtom_Click(object sender, EventArgs e)
        {
            _pressesQueue.Enqueue(PressType.Left);
        }

        private void RightButtom_Click(object sender, EventArgs e)
        {
            _pressesQueue.Enqueue(PressType.Right);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _pressesQueue.Enqueue(PressType.Start);
        }
    }
}
