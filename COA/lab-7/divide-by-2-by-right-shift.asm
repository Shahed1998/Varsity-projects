;Division by right shift
;signed variable
org 100h
.model small
.stack 100
.data
.code
proc main
    mov al, -64
    mov cl, 2
    sar al, cl
    
    mov ah,4ch
    int 21h
    main endp
end main