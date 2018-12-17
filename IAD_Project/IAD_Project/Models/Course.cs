﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace IAD_Project.Models
{
    public class Course
    {
        // Vars
        public string Name { get; set; }

        public int NumOfYears { get; set; }

        public Year[] Years { get; set; }


        // Constructors
        public Course()
        {
            Name = "DEFAULT_NAME";

            NumOfYears = 1;

            Years = new Year[NumOfYears];

            for (int i = 0; i < NumOfYears; i++)
            {
                Years[i] = new Year(i);
            }
        }// Course()

        public Course(string name, int numOfYears)
        {
            Name = name;

            NumOfYears = numOfYears;

            Years = new Year[NumOfYears];

            for (int i = 0; i < numOfYears; i++)
            {
                Years[i] = new Year(i);
            }       
        }// Course(string, int)


        // Methods
        public void SerializeCourse()
        {
            string jsonOutput = JsonConvert.SerializeObject(this);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string filename = Path.Combine(path, "CourseData.txt");

            File.WriteAllText(filename, jsonOutput);

        }// SerializeCourse()


    }// Course

}
