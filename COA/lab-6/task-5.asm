;Write a program to display a "?", read two capital letters, and display them on the next line
;In alphabetical order. Hints: use cmp, jg, xchg 
org 100h
.model small
.stack 100
.data
    ques:db "? $"
    thank:db "Thank you$"
.code
    proc main
        
        mov ax,@data
        mov ds,ax
        
        output_question:     
            lea dx,ques 
            mov ah,9
            int 21h
        
        input_two_letters: 
            mov ah,1
            int 21h
            mov bh, al 
            int 21h
            mov bl, al
                       
        newline:
            xor ax,ax
            xor dx,dx
            mov dl,0dh
            mov ah,2
            int 21h
            mov dl,0ah
            int 21h 
            cmp ch,09
            jz exit  
            
        
        compare:
            cmp bh,bl 
            jng print
            jg exchange
             
            
        exchange:
            xchg bl,bh
            jmp print  

            
        print:
            xor dx,dx
            mov dl,bh
            int 21h
            xor dx,dx
            mov dl,bl
            int 21h 
            mov ch,09
            jmp newline

        exit:  
            lea dx,thank 
            mov ah,9
            int 21h 
            mov ah,4ch
            int 21h
        
        
        main endp
    end main