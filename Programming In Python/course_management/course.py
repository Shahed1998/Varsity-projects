import json
class Course:
    # -------------------------- Add a course --------------------------
    def add_course(self, **kwargs):
        try:
            course = {
                "course_code": int(kwargs.get("course_code")),
                "course_title": kwargs.get("course_title"),
                "course_credit": int(kwargs.get("course_credit")),
                "course_prerequisites": kwargs.get("course_prerequisites")
            }

            with open ("storage.json", "r") as json_object:
                all_courses = json.load(json_object)

            course["id"] = len(all_courses) + 1
            all_courses.append(course)

            with open ("storage.json", "w") as json_object:
                json.dump(all_courses, json_object, indent=4)
                print("successfully entered course")
                    
        except ValueError as ve:
            print(f"Unable to enter course: {ve}")

    # -------------------------- Update a course --------------------------
    def all_courses(self):
        with open ("storage.json", "r") as json_object:
                courses = json.load(json_object)
        # print("id\tcode\ttitle\tcredit\tprerequisites")
        for courseDetails in courses:
            print(f"Course id: {courseDetails['id']}\nCourse code: {courseDetails['course_code']}\nCourse title: {courseDetails['course_title']}\nCourse credit: {courseDetails['course_credit']}\nCourse prerequisites: {courseDetails['course_prerequisites'].split()}\n")