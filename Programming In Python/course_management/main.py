from classes.util import functionalities 

try:
    quit = False
    while quit != True:
        print("\n---------------- Course management system ----------------")
        print( """
                Enter 1 to Add course
                Enter 2 to View all available courses
                Enter 3 to View a course  
                Enter 4 to Update a course
                Enter 5 to Delete a course
                Enter 6 to Quit""")

        print("\n----------------------------------------------------------")
        
        choice = int(input("Select option: ")) 

        # Add course
        if choice == 1: functionalities.add_course()
        
        # View all courses
        elif choice == 2: functionalities.view_all_courses()
            
        # View one course
        elif choice == 3: functionalities.view_one_course()
            
        # Update course
        elif choice == 4: functionalities.update_course()

        # Delete one course
        elif choice == 5: functionalities.delete_course()

        else:
            inp = input("Do you want to quit ? [y/n]")
            if inp.lower() == "y":
                quit = True
                continue
            else:
               continue

        inp = input("Do you want to quit ? [y/n]")
        if inp.lower() == "y":
            quit = True
            continue
        else: continue

    print("Good bye!") 
    
except ValueError as ve:
    print(ve)
