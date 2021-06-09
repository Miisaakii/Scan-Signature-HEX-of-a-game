# Scan-Signature-class-using-memory-for-cheat-engine-C-
I made a class for scan HEX of a game and find his address for add it in the string called OFFSETS easy for use it

Scan hex of a game for find his address (offset) then add it in the string called OFFSETS
this way is more faster for find a address if this address change (dynamic)

I'm still working on it, it's not finish yet but it's working i guess

how to use it ?

add the Memory.dll into your library project (you can find it on google or in NuGet)
then add the variable:

        Mem m = new Mem();
        Signature SCAN = new Signature();
        
when it's done, you can start using it and search the HEX for get his address:
        SCAN.ScanForAdress("C7 40 1C 00 00 00 00 48 83 C4 28 C3 CC CC CC CC 48 89 5C 24 08 55 56 57 41 56 41 57 48 83 EC 50", "FAST_DOWN"); 
        
for exemple, i "FAST_DOWN" is the name of the offset i want, you can change the name in the file Signature.cs or added some new name it's just for save your address in the right place for then using it.

well after do this it's will scan the HEX and get the address then place the address in the string OFFSET with the name you have added and it's done !

Discord: Misaki#2121
