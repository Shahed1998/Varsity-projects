;Division by right shift
;signed variable
org 100h
.model small
.stack 100
.data
.code
proc main
    mov al, 00000011
    rol al, 8
    
    mov ah,4ch
    int 21h
    main endp
end main