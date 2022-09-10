;Put the sum of the first 50 terms of the arithmetic sequence
;1, 5, 9, 13, ... in DX. Hints: Employ LOOP instructions to do the following  

org 100h
.model small
.stack 100
.data     
.code
proc main  
              
    mov cx, 50
    mov ax, 1 
         
    Sum: 
    
        add bx,ax 
        add ax,4
        
    loop Sum
   
    
    Exit:
        mov ah, 4ch
        int 21h
    
    
    
    main endp
end main