using WEBAPI03_ComplexObjectRepo.Model;

namespace WEBAPI03_ComplexObjectRepo
{
    public static class Repository
    {
       public static List<Student> students = new List<Student>()
            {
                new Student() {Id=101,Name="prince",Email="prince@gmail.com" },
                new Student() {Id=102,Name="Muskan",Email="muskan@gmail.com" },
                new Student() {Id=103,Name="Nikki",Email="nikki@gmail.com" },
                new Student() {Id=104,Name="Aman",Email="aman@gmail.com" }
        };
    }
}
