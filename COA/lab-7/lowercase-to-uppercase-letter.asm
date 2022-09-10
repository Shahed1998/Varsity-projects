org 100h
.model small
.stack 100
.data  
    inp:db "Lower case letter: $"
.code
proc main
    mov bx, @data
    mov ds, bx
    
    ;print data
    lea dx, inp   
    mov ah, 9
    int 21h 
    
    ;user input
    mov ah, 1
    int 21h
    
    ;convert to uppercase
    and al, 0dfh
    mov dl, al
    
    ;print   
    mov ah, 2
    int 21h
    
    Exit:
        mov ah, 4ch
        int 21h
    main endp
end main