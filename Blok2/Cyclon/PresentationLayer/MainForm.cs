﻿using Globals.Interfaces;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private readonly ILogic _logic;
        public MainForm(ILogic logic)
        {
            _logic = logic;
            InitializeComponent();

        }
    }
}