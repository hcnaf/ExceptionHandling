namespace Task3.DoNotChange
{
    public class UserTask : ITask
    {
        public UserTask(string description)
        {
            Description = description;
        }

        public string Description { get; }
    }
}