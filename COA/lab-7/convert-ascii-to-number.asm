org 100h
.model small
.stack 100
.data
.code
proc main   
    ;print a character
    mov dl, '?'
    mov ah, 2
    int 21h 
    ;take user input 
    mov ah, 1
    int 21h     
    mov dl, al
    and dl, 0fh
    ;print the number 
    add dl, 48
    mov ah, 2
    int 21h 
    
    
    main endp
end main