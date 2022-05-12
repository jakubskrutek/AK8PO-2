# AK8PO-2# AK8PO  
## Projekt do AK8PO – SW pro zpracování výsledků ze stolního tenisu  
  
#### Scénář  
Online výsledkový servis ze stolního tenisu neposkytuje data v žádné rozumné formě (např. pomocí nějakého REST  
API), a proto tento SW, který bude „vydolovávat“ data ze stránky a ty zpracovat pro potřeby sportovního klubu  
ve formě - nástěnka s výsledky, statistiky, rozpis zápasů atd. pro potřebu tisku přehledných tabulek 
  
#### Požadavky v bodech  
•	jednoduché a intuitivní uživatelské rozhraní  
•	dolování dat ze stránek se sportovními výsledky  
•	vytváření tabulek s výsledky a různými statistickými daty pro potřeby tisku  
•	vytvoření rozpisu (časového harmonogramu soutěže)  
•	export takto seskupených dat v patřičném formátu (např. .xls)  
•	uchovávání dat  
  
#### Použité technologie  
•	Windows Forms - .NET framework pro tvorbu formulářů  
•	Class Library - knihovna tříd bude obsahovat jednotlivé třídy dle zadání  
•	SQL Database / XML - ukládání dat  
•	.xls - pro ukládání pracovních štítků  
  
#### Časový plán  
**00-03 hod.:** úvodní konzultace s vedoucím projektu (učitelem), rozmyšlení funkcionality aplikace, rozvržení práce, odhad časové náročnosti   
**04-08 hod.:** návrh fomulářů pro aplikaci na papír, promyslet třídy, které budou použity, založit projekt, vytvořit  repozitář na Gitu  
**09-12 hod.:** tvorba hlavního formuláře, seznámení se s Windows Forms (začátečník)  
**13-16 hod.:** načtení surových dat ze stránky (pro začátek ruční stažení), napsat logiku pro vydolování potřebných dat z textu  
**17-20 hod.:** seznámit se s možnostmi ukládání dat pomocí SQL nebo XML (začátečník), přidat ukládání do kódu  
**21-24 hod.:** vytvořit druhý formulář pro tvorbu hlavní tabulky (stolní tenis), propojit s hlavním formulářem, oživit formulář - na kliknutí se provede vydolování dat a jejich uložení do souboru  
**25-28 hod.:** vytvořit zbývající formuláře - los, zápisy, úspěšnost  
**29-33 hod.:** napsat logiku pro vydolování dat ke zbylým formulářům  
**34-37 hod.:** propojit všechny formuláře, doladit ukládání souborů, doladit načítání surových dat  
**38-40 hod.:** vytvořit funkci pro export dat do přehledných tabulek  

  
#### Otázky
• Jak nejlépe vyřešit načítání surových dat ze stránky?
