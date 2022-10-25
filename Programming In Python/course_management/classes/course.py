import json
import random

class Course:

    # write into file
    def write_into_file(self,all_courses, message):
        with open ("storage.json", "w") as json_object:
            json.dump(all_courses, json_object, indent=4)
            return(message)

    # read from file
    def read_from_file(self):
        with open ("storage.json", "r") as json_object:
            return json.load(json_object)

    # generate random id
    def generate_random_id(self):
        return random.randint(0,100)

    # check if any course have that id
    def check_course_id(self, rand, all_courses):
        for c in all_courses:
            if rand == c["id"]:
                rand = self.generate_random_id()
                self.check_course_id(rand, all_courses)
        return rand


    # -------------------------- Add a course --------------------------
    def add_course(self, **kwargs):
        try:
            available_courses = []

            all_courses = self.read_from_file()

            for course in all_courses:
                # checks if the course already exist by code
                if int(kwargs.get("course_code")) == course["course_code"]:
                    return "Course already exists"

                # checks if the course already exist by title
                if kwargs.get("course_title") == course["course_title"]:
                    return "Course already exists"

                available_courses.append(course["course_code"])

            # checks if prerequisites are in the available courses
            prerequisites = kwargs.get("course_prerequisites")
            if len(prerequisites) > 0:
                for pre_req in prerequisites:
                    if pre_req not in available_courses:
                        return "Prerequisite course code doesn't exist"
            else: prerequisites = []
               
            course = {
                "course_code": int(kwargs.get("course_code")),
                "course_title": kwargs.get("course_title"),
                "course_credit": int(kwargs.get("course_credit")),
                "course_prerequisites": prerequisites
            }

            # Generate random id
            rand_id = self.generate_random_id()
            # check if any course have that id
            course["id"] = self.check_course_id(rand_id, all_courses)
            # if random id is found append to the course
            all_courses.append(course)
            
            return self.write_into_file(all_courses, "Successfully entered course")
                    
        except ValueError as ve:
            return f"Unable to enter course: {ve}"
        except FileNotFoundError as fe:
            return f"Unable find file: {fe}"

    # -------------------------- View all courses --------------------------
    def all_courses(self):
        
        courses = self.read_from_file()

        if len(courses) < 1: print("No course available")
        else:
            for courseDetails in courses:
                print(f"\nTitle: {courseDetails['course_title']}")
                print(f"Code: {courseDetails['course_code']}")
                print(f"Credit: {courseDetails['course_credit']}")
                if (len(courseDetails['course_prerequisites']) > 0):
                    print(f"Prerequisites: {','.join(str(elem) for elem in courseDetails['course_prerequisites'])}")
                else:
                    print(f"Prerequisites: none")


    # -------------------------- View a course --------------------------
    def view_course(self, course_code):
       
        all_courses = self.read_from_file()

        for course in all_courses:
            if course["course_code"] == course_code:
                msg = f"\nTitle: {course['course_title']}"
                msg += f"\nCode: {course['course_code']}"
                msg += f"\nCredit: {course['course_credit']}"
                if len(course['course_prerequisites']) > 0:
                    msg += f"\nPrerequisites: {','.join(str(elem) for elem in course['course_prerequisites'])}"
                else: 
                    msg += f"\nPrerequisites: none"
                return msg
        
        return "Course doesn't exist"

    # -------------------------- Update a course --------------------------
    def update_course(self, **kwargs):
        try:
            available_courses = []

            all_courses = self.read_from_file()

            # check for prerequisites
            for course in all_courses:
                if course["id"] == kwargs.get("course_id"): continue
                available_courses.append(course["course_code"])

            prerequisites = kwargs.get("course_prerequisites")
            if len(prerequisites) > 0:
                for prereq in prerequisites:
                    if prereq not in available_courses:
                        return "Prerequisite: Course doesn't exist"
            else: prerequisites = []

            # check for id
            for course in all_courses:
                if kwargs.get("course_id") == course["id"]: break
            else:
                return f"Course id: {kwargs.get('course_id')} doesn't exist"
            
            # delete existing data
            course_code = 0
            for i in range(len(all_courses)):
                if kwargs.get("course_id") == all_courses[i]["id"]:
                    course_code = all_courses[i]["course_code"]
                    del all_courses[i]
                    break

            course = {
                "course_code": course_code,
                "course_title": kwargs.get("course_title"),
                "course_credit": int(kwargs.get("course_credit")),
                "course_prerequisites": prerequisites,
                "id": int(kwargs.get("course_id"))
            }

            all_courses.append(course)

            return self.write_into_file(all_courses, "Course successfully updated")
 
        except FileNotFoundError as fe:
            return f"File not found"
        except ValueError as ve:
            return f"Value error: {ve}"


    # -------------------------- Delete a course --------------------------
    def delete_course(self, id):
        try:
            all_courses = self.read_from_file()

            course_code = 0
            for i in range(len(all_courses)):
                if id == all_courses[i]["id"]:
                        
                    course_code = all_courses[i]["course_code"]

                    del all_courses[i]

                    break
            else:
                return("Course not found")

            for course in all_courses:
                if (course_code in course["course_prerequisites"]):
                    course["course_prerequisites"].remove(course_code)

            return self.write_into_file(all_courses, "Course successfully deleted")

        except ValueError as ve: return(f"Unable to delete: {ve}")
        except FileNotFoundError as fe: return(f"Unable find file: {fe}")