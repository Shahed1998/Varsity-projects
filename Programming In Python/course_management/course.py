
class Course:

    def __str__(self):

       return """
        Enter 1 to Add course
        Enter 2 to View a course
        Enter 3 to View all available courses
        Enter 4 to Update a course
        Enter 5 to Delete a course"""

    def add(self, **kwargs):
        course = {
            "course_code": int(kwargs.get("course_code")),
            "course_title": kwargs.get("course_title"),
            "course_credit": int(kwargs.get("course_credit")),
            "course_prerequisites": kwargs.get("course_prerequisites")
        }
        print(course)

