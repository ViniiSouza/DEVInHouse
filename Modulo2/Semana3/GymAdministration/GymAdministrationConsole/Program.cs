using GymAdministration.Core;
using System;
using System.Collections.Generic;

namespace GymAdministrationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i <= 10; i++)
            {
                students.Add(new Student("Fulano", "A+", DateTime.Now, StatusEnum.Active));
            }
            Employee employee = new Employee("Abc");

            ActivityClass activityClass = new ActivityClass("Cba", "description", DateTime.Now);

            List<Equipment> equipments = new List<Equipment>();

            for (int i = 0; i <= 10; i++)
            {
                equipments.Add(new Equipment(0, "Caderno", "description", DateTime.Now));
            }

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i <= 5; i++)
            {
                employees.Add(new Employee("Nome"));
            }

            Console.WriteLine("Lista de estudantes:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("---");
                Console.WriteLine($"Nome: {students[i].Name} - Informações médicas: {students[i].MedicalObservation} - Aniversário: {students[i].BirthdayDate} - Status: {students[i].Status} - {employee.Name} - {activityClass.Name} ({activityClass.Description})");
                Console.WriteLine($"Material: {equipments[i].Name} - {equipments[i].Description}");
            }
            Console.WriteLine("Employees:");
            foreach(var item in employees)
            {
                Console.WriteLine("---");
                Console.WriteLine(item.Name);
            }
        }
    }
}
