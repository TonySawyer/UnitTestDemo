namespace TestApplication.Models.TonySpecific
{
    public class Class1
    {
        public int MyProperty { get; set; }

        public int NewProperty { get; set; }

        public bool CheckBothProperties()
        {
            return this.MyProperty > 0 && this.NewProperty < 100;
        }

        public bool CheckMyProperty()
        {
            return this.MyProperty > 0;
        }
    }
}