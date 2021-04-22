using System;
using System.Collections.Generic;
using System.Linq;
using LearnIt.Data;
using LearnIt.Models;

namespace LearnIt.DatabasePopulator
{
    public static class DatabasePopulator
    {
        public static void Populate(ApplicationDbContext _context)
        {
            PopulateLecturesAndCourses(_context);
        }

        public static void PopulateLecturesAndCourses(ApplicationDbContext _context)
        {
            CourseDataModel c;
            LectureDataModel l;

            /*  Technology Fundamentals  */
            c = new CourseDataModel();
            c.Id = Guid.NewGuid().ToString();
            c.Name = "Technology Fundamentals";
            c.CourseImageLink = @"https://softuni.bg/Files/InternalCourses/Technology_Fundamentals.png";
            c.About = "   The course \"Technology Fundamentals\" expands the acquired initial skills for writing program code from the course \"Fundamentals of Programming\" and introduces basic techniques and tools for practical programming beyond the writing of simple program constructions.\n\n   Along with programming techniques, the course develops algorithmic thinking and builds problem-solving skills by working on hundreds of practical exercises.\n\n   The training methodology is extremely practical. The studied material is presented with a basic theory, with numerous examples and a huge number of practical tasks with increasing difficulty and upgrading one after another, with detailed step-by-step instructions. The practical work in the classroom with the active help of teachers and assistants (or at home for online students) is over 70%.\n\n   During the course, participants will get acquainted with the basics of Web development, which will be studied through practical knowledge of how web applications work in the chosen professional field and will get an idea of ​​the entire training program that awaits them until graduation for software engineer. The course ends with the development of a practical project by students.";
            c.Lectures = new List<LectureDataModel>();

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Basic Syntax, Conditional Statements and Loops";
            l.StartDate = new DateTime(2021, 4, 21);
            l.About = "Introduction to the basic syntax of the programming language.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/01-Intro-and-Basic-Syntax/01. Intro and Basic Syntax.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/01-Intro-and-Basic-Syntax/Lab/01.%20Intro-and-Basic-Syntax-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/NhcQ5gBDJ2E";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Basic HTML";
            l.StartDate = new DateTime(2021, 4, 28);
            l.About = "Introduction to the basic syntax of HTML.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/01-Basic-HTML/HTML.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/01-Basic-HTML/HTML-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/wA2iS4A0hH0";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Data Types and Variables";
            l.StartDate = new DateTime(2021, 5, 1);
            l.About = "Introduction to the basic data types and variables in C#.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/02-Data-Types-and-Variables/02. Data-Types-and-Variables.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/02-Data-Types-and-Variables/Lab/02. Data-Types-and-Variables-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/jUgP7ch4wig";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Basic CSS";
            l.StartDate = new DateTime(2021, 5, 5);
            l.About = "Introduction to the basic syntax of CSS.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/02-Basic-CSS/CSS.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/02-Basic-CSS/CSS -Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/OTlvuXgz1XQ";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Arrays";
            l.StartDate = new DateTime(2021, 5, 8);
            l.About = "Introduction to arrays.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/03-Arrays/03. Arrays.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/03-Arrays/Lab/03. Arrays-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/y-sjcbjOIXs";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "HTTP Basics";
            l.StartDate = new DateTime(2021, 5, 12);
            l.About = "Introduction to HTTP.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/03-HTTP-Basics/HTTP-Basics.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/03-HTTP-Basics/HTTP-Basics-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/HP4j12s6G4o";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Methods / Functions";
            l.StartDate = new DateTime(2021, 5, 15);
            l.About = "Introduction to Methods / Functions.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/04-Methods/04. Methods.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/04-Methods/Lab/04. Methods-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/GSy03aIma5U";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Problem Solving";
            l.StartDate = new DateTime(2021, 5, 19);
            l.About = "Introduction to problem solving techniques.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/04-Problem-Solving/Problem Solving.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/04-Problem-Solving/CSharpEisteinsRiddle/EinsteinsRiddle-Documentation.docx";
            l.VideoLink = @"https://www.youtube.com/embed/O1CKPxAGIRc";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Lists / Arrays Advanced";
            l.StartDate = new DateTime(2021, 5, 22);
            l.About = "Introduction to lists or so called resizable arrays.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/05-Lists/05. Lists.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/05-Lists/Lab/05. Lists-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/1-SfJp3-f7E";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Bitwise Operations";
            l.StartDate = new DateTime(2021, 5, 26);
            l.About = "Introduction to bitwise operations.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/05-Bitwise-Operations/Bitwise-Operations.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/05-Bitwise-Operations/Bitwise-Operations-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/yXZyCQCFbC8";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Associative Arrays";
            l.StartDate = new DateTime(2021, 5, 29);
            l.About = "Introduction to associative arrays.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/06-Dictionaries/06. Dictionaries-Lambda-and-LINQ.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/06-Dictionaries/Lab/06. Dictionaries-Lambda-LINQ-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/wN5HMhyJM3Y";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Intro to Computer Science";
            l.StartDate = new DateTime(2021, 6, 2);
            l.About = "Introduction to computer science.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/06-Intro-to-Computer-Science/05.Intro-To-Computer-Science.pptx";
            l.ExercisesLink = @"";
            l.VideoLink = @"https://www.youtube.com/embed/GA98UW9WfxM";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Objects and Classes";
            l.StartDate = new DateTime(2021, 6, 5);
            l.About = "Introduction to objects and classes.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/07-Objects-and-Classes/07. Objects-and-Classes.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/07-Objects-and-Classes/Lab/07. Objects-and-Classes-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/bRmR8oVhh0o";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Database Basics";
            l.StartDate = new DateTime(2021, 6, 9);
            l.About = "Introduction to basics of databases.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/07-Database-Basics/07. Database-Basics.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/07-Database-Basics/07. Database-Basics-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/UEmnMX2jY0g";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "String and Text Processing";
            l.StartDate = new DateTime(2021, 6, 12);
            l.About = "Introduction to string and text processing.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/08-Strings-and-Text-Processing/08. String-and-Text-Processing.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/08-Strings-and-Text-Processing/Lab/08. Strings-and-Text-Processing-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/0XT5x0BJlCE";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Regular Expressions";
            l.StartDate = new DateTime(2021, 6, 16);
            l.About = "Introduction to regular expressions.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/08-Regular-Expressions/Regular-Expressions-Regex.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/08-Regular-Expressions/Regular-Expressions-Regex-Lab-CSharp.docx";
            l.VideoLink = @"https://www.youtube.com/embed/dKg7_kLwCpM";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Basic Web";
            l.StartDate = new DateTime(2021, 6, 19);
            l.About = "Introduction to basics of the web.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/09-Basic-Web/09. Basic Web.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/09-Basic-Web/Lab/09. Basic Web - Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/LVqbakjP5Eo";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Git and GitHub";
            l.StartDate = new DateTime(2021, 6, 23);
            l.About = "Introduction to Git and GitHub.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/09-Git-and-GitHub/10. Git-and-GitHub.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/09-Git-and-GitHub/10. Git-and-GitHub-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/_DUFWqZjr00";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Git and Basic CRUD";
            l.StartDate = new DateTime(2021, 6, 26);
            l.About = "Introduction to basics of CRUD operations.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/10-Basic CRUD/10. Basic CRUD.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/10-Basic CRUD/Lab/10. Basic CRUD - Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/OFIeRLHU-i0";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "QA Fundamentals";
            l.StartDate = new DateTime(2021, 6, 30);
            l.About = "Introduction to QA Fundamentals.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/10-QA-Fundamentals/QA-Fundamentals.pptx";
            l.ExercisesLink = @"";
            l.VideoLink = @"https://www.youtube.com/embed/VOAUFxgjKPU";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Web Project";
            l.StartDate = new DateTime(2021, 7, 3);
            l.About = "Workshop - Web Project.";
            l.PresentationLink = @"";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/CSharp/11-Web-Project/11. CSharp-Forum.docx";
            l.VideoLink = @"https://www.youtube.com/embed/txRfoJqHu9I";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Open-source Introduction";
            l.StartDate = new DateTime(2021, 7, 7);
            l.About = "Introduction to Open-source.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/soft-tech/Sept-2018/common-lectures/11-Open-Source-Introduction/Open-Source-Introduction.pptx";
            l.ExercisesLink = @"";
            l.VideoLink = @"https://www.youtube.com/embed/zr2TzN1EgzY";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            c.StartDate = c.Lectures[0].StartDate;
            c.EndDate = c.Lectures[c.Lectures.Count - 1].StartDate;
            _context.Courses.Add(c);

            /*  C# Advanced  */
            c = new CourseDataModel();
            c.Id = Guid.NewGuid().ToString();
            c.Name = "C# Advanced";
            c.CourseImageLink = @"https://softuni.bg/Files/InternalCourses/untitled%20folder/C%23%20Advanced.png";
            c.About = "The \"C# Advanced\" course builds on the skills of working with the C# language and the .NET platform, addressing more complex concepts typical of the language. In the course you will learn how to create linear data structures, solve algorithmic problems (problem solving skills), work with streams, files and directories, create template classes. Attention is paid to the paradigm of functional programming, as well as to the main tool relying on it - LINQ for processing data flows. The development environment that will be used by the training team is Microsoft Visual Studio 2021, but each student is free to use tools as desired.";
            c.Lectures = new List<LectureDataModel>();

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Stacks and Queues";
            l.StartDate = new DateTime(2021, 7, 14);
            l.About = "Introduction to stacks and queues.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/01.%20Stacks-And-Queues/01.%20CSharp-Advanced-Stacks-And-Queues.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/01.%20Stacks-And-Queues/01.%20CSharp-Advanced-Stacks-And-Queues-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/QCQUZhc8z5E";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Multidimensional Arrays";
            l.StartDate = new DateTime(2021, 7, 17);
            l.About = "Introduction to multidimensional arrays.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/02.%20Multidimensional-Arrays/02.%20CSharp-Advanced-Multidimensional-Arrays.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/02.%20Multidimensional-Arrays/02.%20CSharp-Advanced-Multidimensional-Arrays-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/0nNy8VQfn7I";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Sets and Dictionaries Advanced";
            l.StartDate = new DateTime(2021, 7, 21);
            l.About = "More on sets and dictionaries.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/03.%20Dictionaries-Advanced-and-Sets/03.%20CSharp-Advanced-Sets-and-Dictionaries-Advanced.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/03.%20Dictionaries-Advanced-and-Sets/03.%20CSharp-Advanced-Sets-and-Dictionaries-Advanced-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/P7xx92C_mNM";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Streams, Files and Directories";
            l.StartDate = new DateTime(2021, 7, 24);
            l.About = "Introduction to streams, files and directories.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/04.%20Streams-Files-and-Directories/04.%20CSharp-Advanced-Streams-Files-and-Directories.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/04.%20Streams-Files-and-Directories/04.%20CSharp-Advanced-Streams-Files-and-Directories-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/ZoquE6u_VkE";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Functional Programming";
            l.StartDate = new DateTime(2021, 7, 28);
            l.About = "Introduction to functional programming.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/05. Functional-Programming/05. CSharp-Advanced-Functional-Programming.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/05. Functional-Programming/05. CSharp-Advanced-Functional-Programming-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/hrSW1L-LnJ0";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Defining Classes";
            l.StartDate = new DateTime(2021, 7, 31);
            l.About = "Introduction to classes and how to define them.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/06. Defining-Classes/06. CSharp-Advanced-Defining-Classes.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/06. Defining-Classes/06. CSharp-Advanced-Defining-Classes-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/B8tb3Ku105Q";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Workshop - Create Linked List";
            l.StartDate = new DateTime(2021, 8, 4);
            l.About = "Workshop - how to create linked list.";
            l.PresentationLink = @"";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/07. Workshop-Custom-Data-Structures/07. Workshop Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/zYihkM2fdRw";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Generics";
            l.StartDate = new DateTime(2021, 8, 7);
            l.About = "Introduction to generics.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/08. Generics/08. CSharp-Advanced-Generics.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/08. Generics/08. CSharp-Advanced-Generics-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/qBPWn5ZglTY";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Iterators and Comparators";
            l.StartDate = new DateTime(2021, 8, 11);
            l.About = "Introduction to iterators and comparators.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/09.%20Iterators-and-Comparators/09.%20CSharp-Advanced-Iterators-and-Comparators.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/09.%20Iterators-and-Comparators/09.%20CSharp-Advanced-Iterators-and-Comparators-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/H459-PMPJ-k";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Workshop - Basic Algorithms";
            l.StartDate = new DateTime(2021, 8, 14);
            l.About = "Workshop - basic algorithms.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-Advanced/10. Workshop-Basic-Algorithms/10. Basic-Algorithms.pptx";
            l.ExercisesLink = @"";
            l.VideoLink = @"https://www.youtube.com/embed/9M8UN1iudSc";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            c.StartDate = c.Lectures[0].StartDate;
            c.EndDate = c.Lectures[c.Lectures.Count - 1].StartDate;
            _context.Courses.Add(c);

            /*  C# OOP  */
            c = new CourseDataModel();
            c.Id = Guid.NewGuid().ToString();
            c.Name = "C# OOP";
            c.CourseImageLink = @"https://softuni.bg/Files/Images/New-images-for-internal-program/CSharp%20oop.jpg";
            c.About = "The course \"C # OOP\" will teach you the principles of object-oriented programming (OOP), to work with classes and objects, to use object-oriented modeling and to build hierarchies of classes. The basic principles of OOP such as abstraction (interfaces, abstract classes), encapsulation, inheritance and polymorphism will be studied. We will go into the most commonly used design patterns (creational, structural and behavioral design patterns). We will get acquainted with the SOLID principles for object-oriented software design. We will look at different debugging techniques. We will learn how to create and use decorators. We will pay attention to component testing (writing unit tests) and the concept of Test Driven Development (TDD).";
            c.Lectures = new List<LectureDataModel>();

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Working with Abstraction";
            l.StartDate = new DateTime(2021, 8, 25);
            l.About = "Introduction to working with abstraction.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/01. Working-with-Abstraction/02. CSharp-OOP-Basics-Working-with-Abstraction.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/01. Working-with-Abstraction/02. CSharp-OOP-Basics-Working-with-Abstraction-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/zOFclMEoz9M";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Encapsulation";
            l.StartDate = new DateTime(2021, 8, 28);
            l.About = "Introduction to encapsulation.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/02. Encapsulation/02. CSharp-OOP-Encapsulation.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/02. Encapsulation/02. CSharp-OOP-Encapsulation-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/XEBKHQEAINc";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Inheritance";
            l.StartDate = new DateTime(2021, 9, 7);
            l.About = "Introduction to inheritance.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/03. Inheritance/03. CSharp-OOP-Inheritance.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/03. Inheritance/03. CSharp-OOP-Inheritance-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/8h0xJiCUIGM";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Interfaces and Abstraction";
            l.StartDate = new DateTime(2021, 9, 11);
            l.About = "Introduction to interfaces and abstraction.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/04. Interfaces-and-Abstraction/04. CSharp-OOP-Interfaces-And-Abstraction.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/04. Interfaces-and-Abstraction/04. CSharp-OOP-Interfaces-and-Abstraction-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/GR2BmsGkWOk";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Polymorphism";
            l.StartDate = new DateTime(2021, 9, 14);
            l.About = "Introduction to polymorphism.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/05. Polymorphism/05. CSharp-OOP-Polymorphism.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/05. Polymorphism/05. CSharp-OOP-Polymorphism-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/O7wwhJE6Vwg";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Solid";
            l.StartDate = new DateTime(2021, 9, 18);
            l.About = "Introduction to the Solid principles.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/06. SOLID/06. CSharp-OOP-SOLID.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/06. SOLID/06. CSharp-OOP-SOLID-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/-p4ikh4GJ9E";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Reflection and Attributes";
            l.StartDate = new DateTime(2021, 9, 21);
            l.About = "Introduction to reflection and attributes.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/07. Reflection-and-Attributes/07. CSharp-OOP-Reflection-And-Attributes.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/07. Reflection-and-Attributes/07. CSharp-OOP-Reflection-And-Attributes-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/TJctIhQmsFY";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Workshop";
            l.StartDate = new DateTime(2021, 9, 25);
            l.About = "Exercising the so far learned material by building a web project.";
            l.PresentationLink = @"";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/08.%20Workshop-DI-Framework/Lab/MuOnline%20-%20Skeleton.zip";
            l.VideoLink = @"https://www.youtube.com/embed/2Wmww2uVVDo";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Unit Testing";
            l.StartDate = new DateTime(2021, 9, 28);
            l.About = "Introduction to Unit testing.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/09. Unit-Testing/09. CSharp-OOP-Unit-Testing-Presentation.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/09. Unit-Testing/09. CSharp-OOP-Unit-Testing-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/eSSFl60GcB8";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Test Driven Development";
            l.StartDate = new DateTime(2021, 10, 1);
            l.About = "Introduction to Test Driven Development (TDD).";
            l.PresentationLink = @"";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/10. Workshop-TDD/Lab/INstock.docx";
            l.VideoLink = @"https://www.youtube.com/embed/tn2yLXpnJVU";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            l = new LectureDataModel();
            l.Id = Guid.NewGuid().ToString();
            l.Name = "Object Communication and Events";
            l.StartDate = new DateTime(2021, 10, 4);
            l.About = "Introduction to object communication and events.";
            l.PresentationLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/11.Object-Communication-and-Events/11. CSharp-OOP-Object-Communication-and-Events.pptx";
            l.ExercisesLink = @"https://softuni.bg/downloads/svn/csharp-fundamentals/2019-Jan/CSharp-OOP/11.Object-Communication-and-Events/11. CSharp-OOP-Object-Communication-and-Events-Lab.docx";
            l.VideoLink = @"https://www.youtube.com/embed/Su9H6ef-HEg";
            c.Lectures.Add(l);
            l.Course = c;
            _context.Lectures.Add(l);

            c.StartDate = c.Lectures[0].StartDate;
            c.EndDate = c.Lectures[c.Lectures.Count - 1].StartDate;
            _context.Courses.Add(c);

            _context.SaveChanges();
        }
    }
}
