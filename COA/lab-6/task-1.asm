;Write an assembly program to print all the ASCII code from 0 to 255.  Hints: use jnz and dec instructions   
org 100h
.model small
.stack 100
.data
.code
proc main
    mov cx, 255
    mov bx, 0
    mov ah, 2
    
    Print_all: 
        mov dx, bx  
        int 21h
        inc bx
        dec cx    
        cmp cx, 0
    jnz Print_all
    
    Exit:
        mov ah, 4ch
        int 21h
    
    main endp
end main