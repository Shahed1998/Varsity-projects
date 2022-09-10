org 100h
.model small
.stack 100h
.data   
    inp:db "Enter characters: $" 
    outp:db "------------------Reverse order------------ $"
    
.code

proc main
        
    mov ax,@data
    mov ds,ax
    
    lea dx,inp
    mov ah,9
    int 21h
    
    xor cx,cx
    
    ;take user inputs until enter
    Looper:
        mov ah,1
        int 21h
        
        ;clearing higher byte
        mov ah,0
        
        push ax
        
        ;increments count
        inc cx     
             
        ; compares if enter is pressed
        cmp al,0dh
        jz BeforeReverse
        jmp Looper
        
        BeforeReverse:
        ;newline
        mov dl,0dh
        mov ah,2
        int 21h
        mov dl,0ah
        int 21h   
        
        ;output
        lea dx,outp
        mov ah,9
        int 21h  
        
        ;newline
        mov dl,0dh
        mov ah,2
        int 21h
        mov dl,0ah
        int 21h
        jmp Reverse
        
        
        
   ;prints the stack in reverse order
   Reverse:    
        ;reverse
        pop bx
        mov dx,bx
        mov ah,2
        int 21h
   
   Loop Reverse
   
   Exit: 
        mov ah,4ch
        int 21h
        
        
   
    main endp
end main