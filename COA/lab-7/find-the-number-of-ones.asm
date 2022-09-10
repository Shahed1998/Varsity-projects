;Reverse bit pattern
org 100h
.model small
.stack 100
.data
.code
proc main 
    mov al, -36
    mov cl, 16
    
    Reverse:
             
            shl al, 1
            rcl al, 1 
             
    loop Reverse  
    
    mov bl, al
    
    mov ah,4ch
    int 21h
    main endp
end main