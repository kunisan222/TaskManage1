using KT_TaskManage.Controller;
using KT_TaskManage.Data;
using static KT_TaskManage.Data.TaskModel;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void �^�X�N�ǉ�()
        {
            var model = new MasterModel();
            var controller = new MainController(model);

            var taskModelList = new List<TaskModel>()
            {
                new(new TaskID(1), "�^�X�N�@", "�^�X�N�@�̐���", TaskType.Active),
                new(new TaskID(2), "�^�X�N�A", "�^�X�N�A�̐���", TaskType.Deactive),
                new(new TaskID(3), "�^�X�N�B", "�^�X�N�B�̐���", TaskType.Active),
                new(new TaskID(4), "�^�X�N�C", "�^�X�N�C�̐���", TaskType.Deactive),
                new(new TaskID(5), "�^�X�N�D", "�^�X�N�D�̐���", TaskType.Active),
            };

            // �^�X�N�ǉ�
            taskModelList.ForEach(v => controller.AddTask(v));

            // �ǉ�����^�X�N��������������
            Assert.AreEqual(model.TaskData.Count, taskModelList.Count);

            // �ǉ������^�X�N�f�[�^������������
            Assert.AreEqual(controller.GetTaskData(new TaskID(1)).Name, "�^�X�N�@");
            Assert.AreEqual(controller.GetTaskData(new TaskID(1)).Description, "�^�X�N�@�̐���");
            Assert.AreEqual(controller.GetTaskData(new TaskID(1)).Type, TaskType.Active);
            Assert.AreEqual(controller.GetTaskData(new TaskID(4)).Type, TaskType.Deactive);
        }

        [TestMethod]
        public void �^�X�N�폜()
        {
            var model = new MasterModel();
            var controller = new MainController(model);

            var taskModelList = new List<TaskModel>()
            {
                new(new TaskID(1), "�^�X�N�@", "�^�X�N�@�̐���", TaskType.Active),
                new(new TaskID(2), "�^�X�N�A", "�^�X�N�A�̐���", TaskType.Deactive),
                new(new TaskID(3), "�^�X�N�B", "�^�X�N�B�̐���", TaskType.Active),
                new(new TaskID(4), "�^�X�N�C", "�^�X�N�C�̐���", TaskType.Deactive),
                new(new TaskID(5), "�^�X�N�D", "�^�X�N�D�̐���", TaskType.Active),
            };

            // �^�X�N�ǉ�
            taskModelList.ForEach(v => controller.AddTask(v));

            // �ǉ������^�X�N���폜�ł��邱��
            controller.DeleteTask(new TaskID(1));
            controller.DeleteTask(new TaskID(2));
            controller.DeleteTask(new TaskID(3));
            Assert.AreEqual(model.TaskData.Count, 2);

            // �^�X�N���擾�ł��邱��
            var taskData = controller.GetTaskData(new TaskID(4));
            Assert.AreEqual(taskData.Id, new TaskID(4));

            // �^�X�N���擾�ł��Ȃ�����
            taskData = controller.GetTaskData(new TaskID(99));
            Assert.AreEqual(taskData.Id, TaskID.Invalid);
        }

        [TestMethod]
        public void �^�X�N�ҏW()
        {
            var model = new MasterModel();
            var controller = new MainController(model);

            var taskModelList = new List<TaskModel>()
            {
                new(new TaskID(1), "�^�X�N�@", "�^�X�N�@�̐���", TaskType.Active),
                new(new TaskID(2), "�^�X�N�A", "�^�X�N�A�̐���", TaskType.Deactive),
                new(new TaskID(3), "�^�X�N�B", "�^�X�N�B�̐���", TaskType.Active),
                new(new TaskID(4), "�^�X�N�C", "�^�X�N�C�̐���", TaskType.Deactive),
                new(new TaskID(5), "�^�X�N�D", "�^�X�N�D�̐���", TaskType.Active),
            };

            // �^�X�N�ǉ�
            taskModelList.ForEach(v => controller.AddTask(v));

            // �^�X�N���ҏW�ł��邱��
            var taskData = controller.GetTaskData(new TaskID(4));
            taskData.Name = "�^�X�N�C��ύX";
            taskData.Description = "�^�X�N�C�̐�����ύX";
            taskData.Type = TaskType.Active;
            controller.EditTask(taskData);

            Assert.AreEqual(controller.GetTaskData(new TaskID(4)).Name, "�^�X�N�C��ύX");
            Assert.AreEqual(controller.GetTaskData(new TaskID(4)).Description, "�^�X�N�C�̐�����ύX");
            Assert.AreEqual(controller.GetTaskData(new TaskID(4)).Type, TaskType.Active);
        }

        [TestMethod]
        public void �^�X�N����()
        {
            var model = new MasterModel();
            var controller = new MainController(model);

            var taskModelList = new List<TaskModel>()
            {
                new(new TaskID(1), "�^�X�N�@", "�^�X�N�@�̐���", TaskType.Active),
                new(new TaskID(2), "�^�X�N�A", "�^�X�N�A�̐���", TaskType.Deactive),
                new(new TaskID(3), "�^�X�N�B", "�^�X�N�B�̐���", TaskType.Active),
                new(new TaskID(4), "�^�X�N�C", "�^�X�N�C�̐���", TaskType.Deactive),
                new(new TaskID(5), "�^�X�N�D", "�^�X�N�D�̐���", TaskType.Active),
            };

            // �^�X�N�ǉ�
            taskModelList.ForEach(v => controller.AddTask(v));

            // �����O�̏�ԃ`�F�b�N
            Assert.AreEqual(controller.GetTaskData(new TaskID(3)).Type, TaskType.Active);

            // �^�X�N��������Ԃɂł��邱��
            controller.ChangeActiveTask(new TaskID(3));
            Assert.AreEqual(controller.GetTaskData(new TaskID(3)).Type, TaskType.Deactive);
        }
    }
}