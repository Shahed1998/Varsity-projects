from course import Course

print("\n---------------- Course management system ----------------")
c1 = Course()
print(c1)
print("\n----------------------------------------------------------")

try:
    choice = int(input("Enter option: ")) 

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


        c1.add(
            course_code = course_code,
            course_title = course_title,
            course_credit = course_credit,
            course_prerequisites = course_prerequisites
        )
        

except ValueError as ve:
    print(ve)