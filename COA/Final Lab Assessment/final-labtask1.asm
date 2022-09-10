org 100h
.model small
.stack 100h
.data  
    outp:dw "The number is palindrome $" 
.code

proc main
        
         mov al, 11111111b 
         mov dh, al
         mov cx, 8
         
         Reverse:
         shl al,1
         rcr bl,1 
         
         Loop Reverse
         
         mov dl,bl  
         
         TEST dh,dl
         jnz Palindrome
         
         Palindrome:
            mov dx, outp
            mov ah,9
            int 21h
        
         
         Exit:
         mov ah,4ch
         int 21h
       
    main endp
end main