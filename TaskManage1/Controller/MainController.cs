using KT_TaskManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_TaskManage.Controller
{
    internal class MainController : MainForm.IController
    {
        MasterData _masterData;
        MainForm _Form;

        public MainController(MasterData masterData, MainForm form)
        {
            this._masterData = masterData;
            this._Form = form;
        }
    }
}
