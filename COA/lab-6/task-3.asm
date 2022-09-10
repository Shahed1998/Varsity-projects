;Put the sum 100 + 95 + 90 + ... + 5 in AX.  Hints: Employ LOOP

org 100h
.model small
.stack 100
.data     
.code
proc main  

    Set_Value: 
        cmp ax,0
        jnz Sum
        mov al,100  
        xor cx,cx   

    Set_Loop:
           mov bx,5
           sub ax,bx 
           div bx  
           mov cx,ax 
           mov bx,95 
           mov ax,100
    jmp Set_Value

         
    Sum: 
        add ax,bx
        sub bx,5 
    loop Sum   
    
    main endp
end main