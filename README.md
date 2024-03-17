# This is a solution for the School Management problem

## SOLID lab 4 -> 7 requirments

 Lab 4 requirements:

* Students can register or unregister from courses
* Students can get grades for each course they attend
* Teachers can teach one or multiple courses
* Teachers can grade students

 Lab 5 requirements:

* Students can see only their grades
* Teachers can see the grades of the students for the courses they are teaching
* Directors can see all grades
* Guest teachers can teach one course but cannot assign or see grades grades

 Lab 6 requirements:

* A student can be a teacher
* A teacher can be a director

* Data should be persisten

 Lab 7 requirement => convert the school management console application to a REST API.

## Solution

 school_management:
  
* students:
   id (PK),
   first_name,
   last_name,
   birth_date,
   email,
   registration_date

* teachers:
   id (PK),
   first_name,
   last_name,
   birth_date,
   email,
   registration_date

* directors:
   id (PK),
   first_name,
   last_name,
   birth_date,
   email,
   registration_date

* courses:
   id (PK),
   name,
   semester,
   year,
   requirements,
   teacher_id (FK)

* grades:
   id (PK),
   grade_notation,
   student_id (FK),
   course_id (FK)

* student_courses:
   id (PK),
   student_id (FK),
   course_id (FK)

### Database Schema

![Database Schema](/assets/images/database-schema.png "School Management Database Schema")
