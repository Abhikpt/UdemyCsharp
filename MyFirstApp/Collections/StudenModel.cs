

public class Student{

    public int ID { get; set; }

    public string Name { get; set; }

    public float GPA { get; set; }

    public Student(int id, string name, float gpa)
    {
        this.ID = id ;
        this.Name = name;
        this.GPA = gpa;

        
    }
}
