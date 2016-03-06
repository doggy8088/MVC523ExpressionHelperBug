using System.ComponentModel;

namespace MVC523ExpressionHelperBug.Models
{
    public class Person
    {
        public int Id { get; set; }

        [DisplayName("姓名")]
        public string Name { get; set; }
    }
}