;Modular program, which represents in middle of the screen isosceles triangle in four ways:
;Round of 0, 90, 180, 270
.MODEL small
.STACK 100h
.DATA
msg1    db 13,10,'Enter the height of the triangle,a negative number for end program$'   
msg2    db 13,10,'Enter the number of spaces that will be between every two characters$'
msg3    db 13,10,'Enter the signal that the triangle will be drawn by him$'
msg4    db 13,10,'Choose which degree you want the triangle will be displayed (0,90,180,270)$'
msg5    db 13,10,'Enter any key to finsih$'
msg6    db 13,10,'EEEEEEEEEEEEEEEE'
        db 13,10,'EEEEE ==== EEEEE'
        db 13,10,'EEEEE Yoav EEEEE'
        db 13,10,'EEEEE ==== EEEEE' 
        db 13,10,'EEEEEEEEEEEEEEEE $'
        
msg7    db 13,10,'The program display triangle according to the conditions below:'
        db 13,10,'The input of the frogram is:'
        db 13,10,'1.The height of the triangle'
        db 13,10,'2.Number of spaces that will be between every two characters'
        db 13,10,'3.Signal that the triangle will be drawn by him'
        db 13,10,'4.The degree of the triangle $'
                 
crlf    db 13,10,'$'
realHigh db 0
high    db 3
highlen db 0
hightxt db 3 dup(0)
spaces  db 0
char    db 0
degree  db 4
degreelen db 0
degreetxt db 4 dup(0)
realDegree dw 0 
basis   db 0
maxTav  db 0        ;The maximum size of the base with no spaces
hSpaces db 0        ;Size base including spaces divided by 2 (for the triangle whill be in the middle of the screen) 
mone    db 0
z       db 1        ;for the high loop
j       db 1        ;loop of the spaces before the triangle 
i       db 0        ;loop of tavs
k       db 1        ;loop of the spaces between evry 2 tavs 
moneSpaces db 0 
spacesBefore db 0
.CODE
        mov AX,@data
        mov DS,AX
        
        call ShowLogo  ;show logo
        call ProgramDescription  ;show Program Description 
MainLoop:                 
        call MovingData
        call GetNum       ;get high (num)
        
        cmp realHigh,99    ;if high < 0 jump to to exit and end program 
        ja Exit 

        call GetSpaces    ;get spaces
        call GetChar      ;get char
        call GetDegree    ;get degree
        call CheckDegree  ;CheckDegree
;**********************************************************************************
                            ;moving data 
;**********************************************************************************                            
MovingData:       
        mov basis,0
        mov maxTav,0
        mov hSpaces,0
        mov mone,0
        mov z,1
        mov j,1
        mov i,0
        mov k,1
        mov moneSpaces,0
        ret                                                                                                                   
;**********************************************************************************
                          ;GetNum!
;**********************************************************************************
GetNum: lea DX,msg1 ;showing msg1      
        mov AH,09h
        int 21h 
       
        lea DX,crlf  ;jumping line
        mov AH,09h
        int 21h 
        
        lea DX,high  ;reading the high from the user
        mov AH,0ah
        int 21h
        
        lea BX,hightxt  ;moving the first byte of hightxt to bx
        sub [BX],48     ;convert the first digit form ascii to binary
        cmp highlen,1
        jna OneDigit
        inc BX          ;jump to the next digit
        
        sub [BX],48     ;convert the second digit form ascii to binary
        dec BX          ;retuern to the first digit
        
        mov AL,10       ;Multiply the first digit by 10
        mov CL,[BX] 
        mul CL
        
        mov realHigh,AL  ;saving the multiply
        
        inc BX       ;jumping to the second digit
        
        mov CL,realHigh
        add CX,[BX] ;adding the second digit to the high to get the binary high 
        mov realHigh,CL ;saving the high 
        cmp highlen,1   ;if the length of the digits bigger than 1
        ja FinishGetNum 
OneDigit: mov BL,hightxt  ;noving the high to "high"
        mov realHigh,BL
FinishGetNum:        
        ret 
;*********************************************************************************** 
                         ;GetChar!
;***********************************************************************************
GetChar:lea DX,msg3      ;showing msg3
        mov AH,09h
        int 21h 
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        mov AH,01h       ;read the singal form the user
        int 21h
        mov char,AL      ;saving the singal
        ret        
;***********************************************************************************                                
                        ;GetSpaces
;***********************************************************************************
GetSpaces:lea DX,msg2      ;showing msg2
        mov AH,09h
        int 21h
        
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h 
                        ;reading the number of the spaces from the user
        mov AH,01h
        int 21h 
        
        mov spaces,AL   ;saving the number of the spaces
        
        sub spaces,48   ;convert the number of the spaces form ascii to binary 
        ret
;***********************************************************************************
                            ;Get Degree                
;************************************************************************************ 
GetDegree:lea DX,msg4      ;showing msg4
        mov AH,09h
        int 21h
        
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        lea DX,degree
        mov AH,0ah
        int 21h
        
        lea BX,degreetxt
        
        cmp [BX],50     ;jump if the first digit of the degree=2
        je Degree270

        cmp [BX],49     ;jump if the first digit of the degree=1
        je Degree180

        cmp [BX],57     ;jump if the first digit of the degree=9
        je Degree90
        
        cmp [BX],48
        je Degree0

Degree270:mov realDegree,270   ;the real degree=270
ret
Degree180:mov realDegree,180   ;the real degree=180
ret
Degree90:mov realDegree,90     ;the real degree=90
ret
Degree0: mov realDegree,0      ;the real degree=0
ret
;**************************************************************************************
                            ;checkDegree
;************************************************************************************
CheckDegree:cmp realDegree,0    ;if the degree=0 jump
        je triangle0
        
        cmp realDegree,90      ;if the degree=90 jump
        je triangle90
        
        cmp realDegree,180     ;if the degree=180 jump
        je triangle180
        
        cmp realDegree,270     ;if the degree=270 jump
        je triangle270  
;************************************************************************************
                            ;triangle0
;************************************************************************************
        
Triangle0:
        
        
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        dec mone        ;mone=-1
        
        mov AL,2          ;2*high
        mov BL,realHigh
        mul BL
        mov basis,AL     ;saving
        dec basis
        mov maxTav,AL    ;saving
        dec maxTav       ;The maximum size of the base with no spaces
        mov BL,maxTav
        dec BL           ;bx=maxTav-1 
        
        mov AL,spaces    ;(maxTav-1)*spaces
        mul BL
        
        mov maxTav,AL    ;saving
        mov CL,basis
        add maxTav,CL  ;maxTav=(maxTav-1)*spaces)+maxTav
        
        mov AL,maxTav      ;(maxTav+(maxTav-1)*spaces)/2 Size base including spaces divided by 2 (for the triangle whill be in the middle of the screen)
        mov BL,2
        div BL
        mov hSpaces,AL
        
                       
                   

LoopHigh:
;**********10
        mov BL,z 
        cmp BL,realHigh        ;jump to the main loop if z>high
        ja MainLoop
        
        add mone,2           ;add to the mone 2     ;enry time you are jumping a line, the line increased by 2
        mov j,1          ;restors the j,k,i to the source
        mov i,0
        mov k,1        
                 ;loop of the spaces before the triangle
LoopSpaceBefore:
;********8 
        mov BL,j
        mov CL,hSpaces
        cmp BL,CL      ;jump when j>hSpaces
        ja LoopTavs 
        cmp CL,200      ;jump to loop tavs if hSpaces=-....
        jae LoopTavs 
        
        mov DL," "        ;desplay space
        mov AH,02h
        int 21h
        
        inc j              ;j=j+1
        mov BL,j
        cmp BL,hSpaces       ;jump back if the j<hSpaces
        jna LoopSpaceBefore
;********8        
LoopTavs:
;*********9
        mov k,1
        inc i           ;i=i+1
        mov BL,i       ;jump if i>mone
        cmp BL,mone
        ja EndLoopSpaceIn
                    

        mov DL,char        ;desplay tav
        mov AH,02h
        int 21h
        
LoopSpaceIn:
;*******7
        mov BL,k
        cmp BL,spaces
        ja LoopTavs
                 
        mov DL," "        ;desplay space
        mov AH,02h
        int 21h
        
        inc k             ;k=k+1
        mov BL,k
        cmp BL,spaces     ;if k<=spaces jump to loopSpaceIn
        jna LoopSpaceIn
;*******7
                            
        mov BL,i
        cmp BL,mone      ;if i<=mone jump to loopTavs
        jna LoopTavs     
;*********9
EndLoopSpaceIn:
        dec hSpaces
        mov BL,spaces
        sub hSpaces,BL 
                
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        inc z            ;z=z+1
        
        mov BL,z
        cmp BL,realHigh  ;if z<=reaHigh jump to hight loop
        jna LoopHigh
;**********10
        jmp MainLoop
;************************************************************************************
                            ;triangle90
;************************************************************************************
triangle90:        
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        mov AL,2          ;2*high
        mov BL,realHigh
        mul BL
        mov basis,AL     ;saving
        dec basis
        mov maxTav,AL    ;saving
        dec maxTav       ;The maximum size of the base with no spaces
        
        mov BL,maxTav
        dec BL           ;bx=maxTav-1         
        mov AL,spaces    ;(maxTav-1)*spaces
        mul BL
        
        mov maxTav,AL    ;saving
        mov CL,basis
        add maxTav,CL  ;maxTav=((maxTav-1)*spaces)+maxTav
        
        mov AL,maxTav      ;(maxTav+(maxTav-1)*spaces)/2 Size base including spaces divided by 2 
        mov BL,2
        div BL
        mov hSpaces,AL
        inc hSpaces        ;(maxTav+(maxTav-1)*spaces)/2 Size base including spaces inc by 1
                           ;hspaces=(maxTav+(maxTav-1)*spaces)/2+1
LoopHigh90:
;**********10
        mov BL,z 
        cmp BL,maxTav        ;jump to the main loop if z>high
        ja MainLoop
                     ;restors the k,i to the source
        mov i,1
        mov k,1
        
        mov BL,z
        cmp hSpaces,BL      ;if hSpaces>=z
        jae moneInc90     ;mone++ 
BackMoneInc90:        
        mov BL,z
        cmp hSpaces,BL      ;if hSpaces<z
        jb  moneDec90      ;mone-- 
BackMoneDec90:
        
LoopTavs90:
;*********9
        
        mov BL,mone
        cmp i,BL         ;if i>mone
        ja LoopSpaceIn90 ;jump to LoopSpaceIn90
        
        mov DL,char        ;desplay tav
        mov AH,02h
        int 21h 
        
        inc i
        
        mov BL,mone
        cmp i,BL 
        jbe LoopTavs90 
;*********9
LoopSpaceIn90:
;*******7
        mov BL,k
        cmp BL,spaces
        ja EndLoopSpaceIn90
        
        lea DX,crlf      ;jumping line
        mov AH,09h       ;jump to LoopSpaceIn90
        int 21h
        
        inc z            ;z++
        inc k            ;k++
        mov BL,k
        cmp BL,spaces      ;if k<=spaces
        jbe LoopSpaceIn90         
EndLoopSpaceIn90:
;*******7
        inc z     ;z++
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        mov BL,z
        cmp BL,maxTav
        jbe LoopHigh90 
;**********10                                                   
;************************************************************************************
                            ;triangle180                                            
;************************************************************************************
triangle180:
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        mov AL,2          ;2*high
        mov BL,realHigh
        mul BL
        mov basis,AL     ;saving
        dec basis
        mov maxTav,AL    ;saving
        dec maxTav       ;The maximum size of the base with no spaces 
        
        ADD maxTav,2     ;in the first time we will get into the highLoop we aren't need to to sub the maxTav in 2  
LoopHigh180:
;**********10
        mov BL,z 
        cmp BL,realHigh        ;jump to the main loop if z>high
        ja MainLoop
        
        sub maxTav,2           ;add to the mone 2     ;enry time you are jumping a line, the line increased by 2
        mov j,0        ;restors the j,k,i to the source
        mov i,0
        mov k,1 
        
                 ;loop of the spaces before the triangle
LoopSpaceBefore180:
;********8 
        mov BL,j
        mov CL,moneSpaces
        cmp BL,CL      ;jump when j>moneSpaces
        jae LoopTavs180 
        cmp CL,200      ;jump to loop tavs if moneSpaces=-....
        jae LoopTavs180 
        
        mov DL," "        ;desplay space
        mov AH,02h
        int 21h
        
        inc j              ;j=j+1
        mov BL,j
        cmp BL,moneSpaces       ;jump back if the j<moneSpaces
        jna LoopSpaceBefore180
;********8        
LoopTavs180:
;*********9
        mov k,1         ;k=k+1
        inc i           ;i=i+1
        mov BL,i       ;jump if i>maxTav
        cmp BL,maxTav
        ja EndLoopSpaceIn180
                    

        mov DL,char        ;desplay tav
        mov AH,02h
        int 21h
LoopSpaceIn180:
;*******7
        mov BL,k
        cmp BL,spaces
        ja LoopTavs180
                 
        mov DL," "        ;desplay space
        mov AH,02h
        int 21h
        
        inc k             ;k=k+1
        mov BL,k
        cmp BL,spaces     ;if k<=spaces jump to loopSpaceIn
        jna LoopSpaceIn180
;*******7
                            
        mov BL,i
        cmp BL,maxTav      ;if i<=mone jump to loopTavs
        jna LoopTavs180     
;*********9
EndLoopSpaceIn180:
        add monespaces,1   ;moneSpaces=moneSpaces+1
        mov BL,spaces      ;monespaces=moneSpaces+spaces
        add moneSpaces,BL
                 
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        inc z            ;z=z+1
        
        mov BL,z
        cmp BL,realHigh  ;if z<=reaHigh jump to hight loop
        jna LoopHigh180
;**********10
        jmp MainLoop 
;************************************************************************************
                            ;triangle270
;************************************************************************************
triangle270:
        mov BL,realHigh
        mov spacesBefore,BL
                                
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        mov AL,2          ;2*high
        mov BL,realHigh
        mul BL
        mov basis,AL     ;saving
        dec basis
        mov maxTav,AL    ;saving
        dec maxTav       ;The maximum size of the base with no spaces
        
        mov BL,maxTav
        dec BL           ;bx=maxTav-1         
        mov AL,spaces    ;(maxTav-1)*spaces
        mul BL
        
        mov maxTav,AL    ;saving
        mov CL,basis
        add maxTav,CL  ;maxTav=((maxTav-1)*spaces)+maxTav
        
        mov AL,maxTav      ;(maxTav+(maxTav-1)*spaces)/2 Size base including spaces divided by 2 
        mov BL,2
        div BL
        mov hSpaces,AL
        inc hSpaces        ;(maxTav+(maxTav-1)*spaces)/2 Size base including spaces inc by 1
                           ;hspaces=(maxTav+(maxTav-1)*spaces)/2+1 
                           
LoopHigh270:
;**********10
        mov BL,z 
        cmp BL,maxTav        ;jump to the main loop if z>high
        ja MainLoop
                     ;restors the k,i to the source
        mov i,1
        mov k,1
        mov j,1
        
        mov BL,z
        cmp hSpaces,BL      ;if hSpaces>=z
        jae moneInc270     ;mone++&&spacesBefore-- 
BackMoneInc270:        
        mov BL,z
        cmp hSpaces,BL      ;if hSpaces<z
        jb  moneDec270      ;mone--&&spacesBefore++ 
BackMoneDec270:
                 ;loop of the spaces before the triangle
LoopSpaceBefore270:
;********8 
        mov BL,j
        mov CL,spacesBefore
        cmp BL,CL      ;jump when j>spacesBefore
        ja  LoopTavs270 
        cmp CL,200      ;jump to loop tavs if moneSpaces=-....
        jae LoopTavs270
        
        mov DL," "        ;desplay space
        mov AH,02h
        int 21h
        
        inc j              ;j=j+1
        mov BL,j
        cmp BL,spacesBefore       ;jump back if the j<hSpaces
        jna LoopSpaceBefore270
;********8
LoopTavs270:
;*********9
        
        mov BL,mone
        cmp i,BL         ;if i>mone
        ja LoopSpaceIn270 ;jump to LoopSpaceIn90
        
        mov DL,char        ;desplay tav
        mov AH,02h
        int 21h 
        
        inc i
        
        mov BL,mone
        cmp i,BL 
        jbe LoopTavs270 
;*********9
LoopSpaceIn270:
;*******7
        mov BL,k
        cmp BL,spaces         ;if k>spaces
        ja EndLoopSpaceIn270
        
        lea DX,crlf      ;jumping line
        mov AH,09h       
        int 21h
        
        inc z            ;z++
        inc k            ;k++
        mov BL,k
        cmp BL,spaces      ;if k<=spaces
        jbe LoopSpaceIn270         
EndLoopSpaceIn270:
;*******7
        inc z     ;z++
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        mov BL,z
        cmp BL,maxTav
        jbe LoopHigh270 
;**********10
        jmp MainLoop
;************************************************************************************
                            ;ProgramDescription
;************************************************************************************
ProgramDescription:
        lea DX,msg7   ;show the description
        mov AH,09h
        int 21h 
        
        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h
        
        ret                                           
;************************************************************************************
                            ;moneDec270+spacesBefore
;************************************************************************************
moneDec270:
        dec mone  ;mone=mone-1
        inc spacesBefore   ;spacesBefore=spacesBefore+1
        jmp BackMoneDec270                                                       
;************************************************************************************
                            ;moneInc270+spacesBefore
;************************************************************************************
moneInc270:
        inc mone  ;mone=mone+1
        dec spacesBefore   ;spacesBefore=spacesBefore-1
        jmp BackMoneInc270                                                                   
;************************************************************************************
                            ;showLogo 
;************************************************************************************
ShowLogo:        
        lea DX,msg6       ;show logo(msg6)
        mov AH,09h
        int 21h
        ret
;************************************************************************************
                            ;moneInc90
;************************************************************************************
moneInc90:
        inc mone  ;mone=mone+1
        jmp BackMoneInc90
;************************************************************************************
                            ;moneDec90
;************************************************************************************
moneDec90:
        dec mone  ;mone=mone-1
        jmp BackMoneDec90                             
;************************************************************************************
                            ;Exit
;***********************************************************************************
Exit:   lea DX,msg5      ;showing msg5
        mov AH,09h
        int 21h

        lea DX,crlf      ;jumping line
        mov AH,09h
        int 21h 
        
        mov AH,01h     ;reading a character
        int 21h   
        
        mov AH,4Ch     ;finish program
        int 21h
END        
;************************************************************************************                                                                     