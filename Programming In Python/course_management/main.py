from course import Course

print("\n---------------- Course management system ----------------")
print( """
        Enter 1 to Add course
        Enter 2 to View all available courses
        Enter 3 to View a course  
        Enter 4 to Update a course
        Enter 5 to Delete a course""")
print("\n----------------------------------------------------------")

try:
    c1 = Course()
    choice = int(input("Select option: ")) 

    # Add course
    if choice == 1:
        course_code = input("Enter course code: ")
        course_title = input("Enter course title: ")
        course_credit = input("Enter course credit: ")
        course_prerequisites = []
        pre_req_loop_input = ""

        while not pre_req_loop_input == "quit":
            pre_req_loop_input = input("Enter prerequisite. Type quit to exit: ").strip()
            if pre_req_loop_input == "quit": continue
            course_prerequisites.append(pre_req_loop_input)

        c1.add_course(
            course_code = course_code,
            course_title = course_title,
            course_credit = course_credit,
            course_prerequisites = course_prerequisites
        )
    
    if choice == 2:
        c1.all_courses()
        

except ValueError as ve:
    print(ve)