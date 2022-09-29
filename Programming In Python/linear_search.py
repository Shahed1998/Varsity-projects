def linear_search(arr, uinp):
    for i in arr:
        if uinp != i: continue
        else: return True
    else: return False

def main():
    try:
        uinp = int(input("Enter the size of the array: "))
        arr = []
        for i in range(uinp):
            arr.append(int(input(f"Enter value at index {i}: ")))
        arr_len = len(arr)
        uinp = int(input("Enter the value to search: "))
        return linear_search(arr, uinp)
    except ValueError as e:
        return(f"Error: {e}")

print(main())


        
        
        