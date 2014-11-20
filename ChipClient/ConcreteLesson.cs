namespace ChipClient
{
    public class ConcreteLesson
    {
        public ServiceReference.ConcreteLesson Lesson { get; set; }
        public string Name { 
            get { return Lesson.Subject !=null ? Lesson.Subject.Name : string.Empty; }
        }
    }
}