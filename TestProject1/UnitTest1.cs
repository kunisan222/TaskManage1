using KT_TaskManage.Controller;
using KT_TaskManage.Data;
using static KT_TaskManage.Data.TaskModel;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void タスク追加()
        {
            var model = new MasterModel();
            var controller = new MainController(model);

            var taskModelList = new List<TaskModel>()
            {
                new(new TaskID(1), "タスク①", "タスク①の説明", TaskType.Active),
                new(new TaskID(2), "タスク②", "タスク②の説明", TaskType.Deactive),
                new(new TaskID(3), "タスク③", "タスク③の説明", TaskType.Active),
                new(new TaskID(4), "タスク④", "タスク④の説明", TaskType.Deactive),
                new(new TaskID(5), "タスク⑤", "タスク⑤の説明", TaskType.Active),
            };

            // タスク追加
            taskModelList.ForEach(v => controller.AddTask(v));

            // 追加するタスク数が正しいこと
            Assert.AreEqual(model.TaskData.Count, taskModelList.Count);

            // 追加したタスクデータが正しいこと
            Assert.AreEqual(controller.GetTaskData(new TaskID(1)).Name, "タスク①");
            Assert.AreEqual(controller.GetTaskData(new TaskID(1)).Description, "タスク①の説明");
            Assert.AreEqual(controller.GetTaskData(new TaskID(1)).Type, TaskType.Active);
            Assert.AreEqual(controller.GetTaskData(new TaskID(4)).Type, TaskType.Deactive);
        }

        [TestMethod]
        public void タスク削除()
        {
            var model = new MasterModel();
            var controller = new MainController(model);

            var taskModelList = new List<TaskModel>()
            {
                new(new TaskID(1), "タスク①", "タスク①の説明", TaskType.Active),
                new(new TaskID(2), "タスク②", "タスク②の説明", TaskType.Deactive),
                new(new TaskID(3), "タスク③", "タスク③の説明", TaskType.Active),
                new(new TaskID(4), "タスク④", "タスク④の説明", TaskType.Deactive),
                new(new TaskID(5), "タスク⑤", "タスク⑤の説明", TaskType.Active),
            };

            // タスク追加
            taskModelList.ForEach(v => controller.AddTask(v));

            // 追加したタスクが削除できること
            controller.DeleteTask(new TaskID(1));
            controller.DeleteTask(new TaskID(2));
            controller.DeleteTask(new TaskID(3));
            Assert.AreEqual(model.TaskData.Count, 2);

            // タスクが取得できること
            var taskData = controller.GetTaskData(new TaskID(4));
            Assert.AreEqual(taskData.Id, new TaskID(4));

            // タスクが取得できないこと
            taskData = controller.GetTaskData(new TaskID(99));
            Assert.AreEqual(taskData.Id, TaskID.Invalid);
        }

        [TestMethod]
        public void タスク編集()
        {
            var model = new MasterModel();
            var controller = new MainController(model);

            var taskModelList = new List<TaskModel>()
            {
                new(new TaskID(1), "タスク①", "タスク①の説明", TaskType.Active),
                new(new TaskID(2), "タスク②", "タスク②の説明", TaskType.Deactive),
                new(new TaskID(3), "タスク③", "タスク③の説明", TaskType.Active),
                new(new TaskID(4), "タスク④", "タスク④の説明", TaskType.Deactive),
                new(new TaskID(5), "タスク⑤", "タスク⑤の説明", TaskType.Active),
            };

            // タスク追加
            taskModelList.ForEach(v => controller.AddTask(v));

            // タスクが編集できること
            var taskData = controller.GetTaskData(new TaskID(4));
            taskData.Name = "タスク④を変更";
            taskData.Description = "タスク④の説明を変更";
            taskData.Type = TaskType.Active;
            controller.EditTask(taskData);

            Assert.AreEqual(controller.GetTaskData(new TaskID(4)).Name, "タスク④を変更");
            Assert.AreEqual(controller.GetTaskData(new TaskID(4)).Description, "タスク④の説明を変更");
            Assert.AreEqual(controller.GetTaskData(new TaskID(4)).Type, TaskType.Active);
        }

        [TestMethod]
        public void タスク完了()
        {
            var model = new MasterModel();
            var controller = new MainController(model);

            var taskModelList = new List<TaskModel>()
            {
                new(new TaskID(1), "タスク①", "タスク①の説明", TaskType.Active),
                new(new TaskID(2), "タスク②", "タスク②の説明", TaskType.Deactive),
                new(new TaskID(3), "タスク③", "タスク③の説明", TaskType.Active),
                new(new TaskID(4), "タスク④", "タスク④の説明", TaskType.Deactive),
                new(new TaskID(5), "タスク⑤", "タスク⑤の説明", TaskType.Active),
            };

            // タスク追加
            taskModelList.ForEach(v => controller.AddTask(v));

            // 完了前の状態チェック
            Assert.AreEqual(controller.GetTaskData(new TaskID(3)).Type, TaskType.Active);

            // タスクを完了状態にできること
            controller.ChangeActiveTask(new TaskID(3));
            Assert.AreEqual(controller.GetTaskData(new TaskID(3)).Type, TaskType.Deactive);
        }
    }
}