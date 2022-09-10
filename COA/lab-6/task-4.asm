;Read a character and display it 50 times on the next line.
;Hints: use LOOP instructions and put cx = 50
org 100h
.model small
.stack 100
.data   
    text:db "Enter a character: $"
.code  
    proc main
        mov ax,@data 
        mov ds,ax
        
        lea dx,text 
        mov ah,9
        int 21h
        
        ;user input
        mov ah,1  
        int 21h   
        mov bl,al
        
        ;newline
        mov ah, 2
        mov dx,0dh 
        int 21h
        mov dx,0ah
        int 21h  
        
        ;print  
        mov cx,50
        
        Print:
              xor dx,dx
              mov dl,bl 
              xor ax,ax
              mov ah, 2
              int 21h 
        loop Print
        
        Exit:
            mov ah,4ch
            int 21h
        
        main endp
    end main
        
        
        
        