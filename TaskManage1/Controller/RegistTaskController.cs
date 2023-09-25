using KT_TaskManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_TaskManage.Controller
{
    internal class RegistTaskController : RegistTaskForm.IController
    {
        MasterData _masterData;
        RegistTaskForm _form;

        public RegistTaskController(MasterData masterData, RegistTaskForm morf)
        {
            _masterData = masterData;
            _form = morf;
        }

        public bool IsActive()
        {
            throw new NotImplementedException();
        }

        public int MaxTaskId()
        {
            throw new NotImplementedException();
        }

        public int MinTaskId()
        {
            throw new NotImplementedException();
        }
    }
}
