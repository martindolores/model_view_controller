using System;
using System.Collections.Generic;
using System.Text;
using ModelViewController.Model;

namespace ModelViewController.Controller
{
    public class ExampleController
    {
        private Example _model;
        private ExampleView _view;

        public ExampleController(Example model, ExampleView view)
        {
            this._model = model;
            this._view = view;
        }

        public void UpdateData(string data)
        {
            _model.Data = data;
            _view.UpdateView(_model.Data);
        }
    }
}
