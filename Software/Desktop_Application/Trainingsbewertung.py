#Programm zur Bestimmung ihrer "Trainingsbewertung"

Name = input("Dein Name:")
gleichst_poss = input("Gleichstand möglich?(j/n):")
ges =int(input("Gesamtzahl Ihrer Gefechte:"))

pkt = 0

i = 0

k = 0

l = 0
n = "n"
j = "j"
geg_trf_ndlrg = 0

geg_trf_sieg = 0

pkt_ndrlg = 0
pkt_gleich= 0
geg_pkt_gleich = 0
if (gleichst_poss !=j):
    if (ges != 0):
        az_siege = int(input("Anzahl Ihrer Trainingssiege:"))
    
        if (az_siege != ges and az_siege != 0):
            az_niederlagen = ges -az_siege
            print("Anzahl Ihrer Niederlagen: ", az_niederlagen)
    
        elif (az_siege == ges):
            az_niederlagen = 0
        
        elif (az_siege == 0):
            az_niederlagen = ges
        
        if (az_niederlagen > 0):
            for az_niederlagen  in range (i, az_niederlagen):
                pkt_pro_niederlage = int (input("Treffer Niederlage :"))
                pkt_gegner_niederlage = int (input("Gegentreffer Niederlage:"))
            
                if (pkt_pro_niederlage == pkt_gegner_niederlage):
                    print("c")
                    pkt_pro_niederlage = int (input("Treffer Niederlage :"))
                    pkt_gegner_niederlage = int (input("Gegentreffer Niederlage:"))
                
                if (pkt_pro_niederlage > pkt_gegner_niederlage):
                    print("Gesetzte Treffer Dürfen nicht größerals die Gegentreffer sein.")
                    pkt_pro_niederlage = int (input("Treffer Niederlage :"))
                    pkt_gegner_niederlage = int (input("Gegentreffer Niederlage:"))

                pkt_ndrlg = pkt_ndrlg + pkt_pro_niederlage
                geg_trf_ndlrg = geg_trf_ndlrg +  pkt_gegner_niederlage
   
        if (az_siege > 0):
            for az_siege  in range( k, az_siege):
                pkt_pro_sieg = int(input("Treffer Sieg:"))
                pkt_gegner_sieg = int(input("Gegentreffer Sieg:"))
              
                if (pkt_pro_sieg == pkt_gegner_sieg):
                    print("Gegentreffer und gestzte Treffer Dürfen nicht Gleich sein.")
                    pkt_pro_sieg = int(input("Treffer Sieg:"))
                    pkt_gegner_sieg = int(input("Gegentreffer Sieg:"))
                
                if (pkt_pro_sieg < pkt_gegner_sieg):
                    print("Gegentreffer dürfen nicht größetr als  Treffer.")
                    pkt_pro_sieg = int(input("Treffer Sieg:"))
                    pkt_gegner_sieg = int(input("Gegentreffer Sieg:"))
                
                geg_trf_sieg = geg_trf_sieg + pkt_gegner_sieg
                pkt= pkt+ pkt_pro_sieg

        sk =(((pkt_ndrlg /2)+(pkt*2))+(az_siege*10)-(az_niederlagen*5)-(geg_trf_sieg/2)-(geg_trf_ndlrg*2))
 
        pk_durchschnitt = sk / ges

        treffer_ges = pkt_ndrlg+pkt

        geg_treff_ges = geg_trf_ndlrg + geg_trf_sieg

        geg_treff_durch = geg_treff_ges /ges

        treffer_durchschnitt = treffer_ges/ ges

        trefferdiff = treffer_ges - geg_treff_ges

        print(Name,":Deine Trainingsbewertung beträgt:",sk ,"Pkt")

        print(Name,":Deine Durchschnittspunkte pro Gefecht betragen:",pk_durchschnitt,"Pkt")

        print(Name,":Durchschnittstreffer pro Gefecht:", treffer_durchschnitt)

        print(Name,":Deine Insgesamt gesetzten Treffer:",treffer_ges)      

        print(Name,":Deine Durchschnittsgegentreffer pro Gefecht:", geg_treff_durch)

        print(Name,":Deine Gegentreffer Insgesamt:",geg_treff_ges )

        print(Name,":Deine Treffer Differenz:", trefferdiff)

    else:

        print("Anzahl Gefechte kann nicht null sein")
        
        
elif (gleichst_poss == j):
    if (ges != 0):
        az_siege = int(input("Anzahl Ihrer Trainingssiege:"))
    
        if (az_siege != ges and az_siege !=0 or az_siege == 0):
            az_niederlagen = int(input("Anzahl Ihrer Trainingsniederlagen:"))
          
            if(az_siege + az_niederlagen != ges):
                az_gleich = ges - (az_siege + az_niederlagen)
                print("Anzahl ihrer Gleichstaende:",az_gleich)
                
            if (az_niederlagen > 0):
                for az_niederlagen  in range (i, az_niederlagen):
                    pkt_pro_niederlage = int (input("Treffer Niederlage :"))
                    pkt_gegner_niederlage = int (input("Gegentreffer Niederlage:"))
            
                    if (pkt_pro_niederlage == pkt_gegner_niederlage):
                        print("Gegentreffer und gestzte Treffer Dürfen nicht Gleich sein")
                        pkt_pro_niederlage = int (input("Treffer Niederlage :"))
                        pkt_gegner_niederlage = int (input("Gegentreffer Niederlage:"))
            
                    if (pkt_pro_niederlage > pkt_gegner_niederlage):
                        print("Gesetzte Treffer Dürfen nicht größerals die Gegentreffer sein.")
                        pkt_pro_niederlage = int (input("Treffer Niederlage :"))
                        pkt_gegner_niederlage = int (input("Gegentreffer Niederlage:"))

                pkt_ndrlg = pkt_ndrlg + pkt_pro_niederlage
                geg_trf_ndlrg = geg_trf_ndlrg +  pkt_gegner_niederlage

            if (az_siege > 0):
                for az_siege  in range( k, az_siege):
                    pkt_pro_sieg = int(input("Treffer Sieg:"))
                    pkt_gegner_sieg = int(input("Gegentreffer Sieg:"))
              
                    if (pkt_pro_sieg == pkt_gegner_sieg):
                        print("Gegentreffer dürfen nicht großer als die gestzten Treffer sein.")
                        pkt_pro_sieg = int(input("Treffer Sieg:"))
                        pkt_gegner_sieg = int(input("Gegentreffer Sieg:"))
                
                    if (pkt_pro_sieg < pkt_gegner_sieg):
                        print("Gegentreffer und gestzte Treffer Dürfen nicht Gleich sein")
                        pkt_pro_sieg = int(input("Treffer Sieg:"))
                        pkt_gegner_sieg = int(input("Gegentreffer Sieg:"))
                
                    geg_trf_sieg = geg_trf_sieg + pkt_gegner_sieg
                    pkt= pkt+ pkt_pro_sieg
            
            if (az_gleich > 0):
                for az_gleich in range (l, az_gleich):
                    pkt_pro_gleich = int(input( "Treffer gesetzt Gleichstand:"))
                    pkt_gleich = pkt_gleich + pkt_pro_gleich
                    geg_pkt_gleich = geg_pkt_gleich + pkt_pro_gleich
               
             
            sk =pkt_ndrlg /2+pkt*2+pkt_gleich+az_siege*10-az_niederlagen*5-geg_trf_sieg/2-geg_trf_ndlrg*2
                 
            pk_durchschnitt = sk / ges

            treffer_ges = pkt_ndrlg+pkt + pkt_gleich

            geg_treff_ges = geg_trf_ndlrg + geg_trf_sieg + geg_pkt_gleich

            geg_treff_durch = geg_treff_ges /ges

            treffer_durchschnitt = treffer_ges/ ges

            trefferdiff = treffer_ges - geg_treff_ges

            print(Name,":Deine Trainingsbewertung beträgt:",sk ,"Pkt")
    
            print(Name,":Deine Durchschnittspunkte pro Gefecht betragen:",pk_durchschnitt,"Pkt")

            print(Name,":Durchschnittstreffer pro Gefecht:", treffer_durchschnitt)

            print(Name,":Deine Insgesamt gesetzten Treffer:",treffer_ges)      

            print(Name,":Deine Durchschnittsgegentreffer pro Gefecht:", geg_treff_durch)

            print(Name,":Deine Gegentreffer Insgesamt:",geg_treff_ges )

            print(Name,":Deine Treffer Differenz:", trefferdiff)

    else:
        print("Anzahl Gefechte kann nicht null sein")