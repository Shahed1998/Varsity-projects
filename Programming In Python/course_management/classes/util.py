from classes.course import Course

class functionalities:
    
    # Course adding functionality
    @staticmethod
    def add_course():
        c1 = Course()
        course_code = int(input("Enter course code: "))
        course_title = input("Enter course title: ")
        course_credit = int(input("Enter course credit: "))
        course_prerequisites = []
        pre_req_loop_input = ""

        while not pre_req_loop_input == "quit":
            pre_req_loop_input = input("Enter prerequisite. Type quit to exit: ").strip()
            if pre_req_loop_input == "quit": continue
            course_prerequisites.append(int(pre_req_loop_input))

        print(c1.add_course(
            course_code = course_code,
            course_title = course_title,
            course_credit = course_credit,
            course_prerequisites = course_prerequisites
        ))

    # View all courses
    @staticmethod
    def view_all_courses(): 
        c1 = Course()
        c1.all_courses()

    # View one course
    @staticmethod
    def view_one_course():
        c1 = Course()
        course_code = int(input("Enter course code: "))
        print(c1.view_course(course_code))

    # Update one course
    @staticmethod
    def update_course():
        c1 = Course()
        id = int(input("Enter course id: "))
        course_title = input("Enter course title: ")
        course_credit = int(input("Enter course credit: "))
        course_prerequisites = []
        pre_req_loop_input = ""

        while not pre_req_loop_input == "quit":
            pre_req_loop_input = input("Enter prerequisite. Type quit to exit: ").strip()
            if pre_req_loop_input == "quit": continue
            course_prerequisites.append(int(pre_req_loop_input))

        print(c1.update_course(
            course_id = id,
            course_title = course_title,
            course_credit = course_credit,
            course_prerequisites = course_prerequisites
        ))

    # Delete a course
    @staticmethod
    def delete_course():
        c1 = Course()
        id = int(input("Enter course id: "))
        print(c1.delete_course(id))