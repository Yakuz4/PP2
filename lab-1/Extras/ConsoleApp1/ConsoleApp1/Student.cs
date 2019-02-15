using System;

public class Student
{
    public string Name;

    public int id;

    public int yearOfStudy;

    public Student(string aName, int anId, int aYearOfStudy)
    {

        Name = aName;

        id = anId;

        yearOfStudy = aYearOfStudy;

    }

    public int yearInc(int yearOfStudy)
    {

        yearOfStudy++;

        return yearOfStudy;

    }
}
