org 100h
.model small
.stack 100h
.data   
.code

proc main
        
         ;character output
         mov dl,'?'
         mov ah,2
         int 21h
         
         
         ;character input
         mov ah,1
         int 21h
         mov bh,al
         
         ;next character input
         int 21h
         mov bl,al    
         
         ;newline
         mov dl,0dh
         mov ah,2
         int 21h
         mov dl, 0ah
         int 21h
         
         ;compare the number
         cmp bh,bl
         jg Reorder
         jng Okay
         
         Reorder:
         mov dl,bl
         mov ah,2
         int 21h
         mov dl,bh
         int 21h
         jmp Exit
         
         Okay:
         mov dl,bh
         mov ah,2
         int 21h
         mov dl,bl
         int 21h
         jmp Exit
         
         
         Exit:
         mov ah,4ch
         int 21h
        
        
        
        
    
    
    
    main endp
end main