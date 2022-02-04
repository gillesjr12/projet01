using System.ComponentModel.Design;
using System.Diagnostics;
//
// 2.1
Console.Write("Entrez un nombre, puis nous allons calculer le carree : ");
int nmb = int.Parse(Console.ReadLine());
int NmbTotal = nmb * nmb;
Console.Write("Le carree de " + nmb + " = " + NmbTotal);
//
//
Thread.Sleep(2000);
Console.Clear();
//
// 2.2
Console.Write("Quel est le prix de vente : " );
double nmb2 = double.Parse(Console.ReadLine());
Console.WriteLine("Montant :" + nmb2);
double nmb2tps = nmb2 * 0.05;
nmb2tps = Math.Round(nmb2tps, 2);
Console.WriteLine("TPS : " + nmb2tps);
double nmb2tvq = nmb2 * 0.09975;
nmb2tvq = Math.Round(nmb2tvq, 2);
Console.WriteLine("TVQ : " + nmb2tvq);
double Total = nmb2 + nmb2tps + nmb2tvq;
Total = Math.Round(Total, 2);
Console.WriteLine("Total :" + Total);
//
//
Thread.Sleep(2000);
Console.Clear();
//
//2.3
Console.Write("Veuillez entrez la temperature de l'eau, puis nous allons verifier son etat : ");
float TmpEau = float.Parse(Console.ReadLine());
if (TmpEau < 0)
{
    Console.WriteLine("Ceci est de la glace, car c'est en bas de 0 degree.");
}
else if ((TmpEau >= 0) && (TmpEau < 100))
{
    Console.WriteLine("Ceci est de l'eau, car elle se situe entre 0 et 100 degree.");
}
else
{
    Console.WriteLine("Ceci est du gaz, car l'eau s'evapore.");
}
//
//
Thread.Sleep(2000);
Console.Clear();
//
//2.4
Console.Write("Maintenant, entrez le diametre d'une sphere, puis nous allons calculer le volume : ");
double DiameterCircle = double.Parse(Console.ReadLine());
double RayonCircle;
double VolumeCircle;
RayonCircle = DiameterCircle / 2;
VolumeCircle = ((4 * Math.PI) / 3) * Math.Pow(RayonCircle, 3);
VolumeCircle = Math.Round (VolumeCircle, 2);
Console.WriteLine("Le volume de la sphere ayant " + DiameterCircle + " de diametre est de " + VolumeCircle);
//
//
Thread.Sleep(3000);
Console.Clear();
//
//2.5
Console.WriteLine("Maintenant nous allons regarder si un nombre est divisible par 5, mais pas par 7.");
Console.Write("Entrez votre nombre : ");
float NmbDemand = float.Parse(Console.ReadLine());
float NmbDemand5;
NmbDemand5 = NmbDemand / 5;

if((NmbDemand % 5 == 0) && (NmbDemand % 7 != 0))
{
    Console.WriteLine("Votre nombre se divise par 5, mais pas par 7 puis cela donne " + NmbDemand5);
}
else
{
    Console.WriteLine("C'est un nombre invalide, car il se divise par 7, mais pas par 5 ou il ne se divise tout simplement pas par les deux chiffres.");
}
//
//
Thread.Sleep(3000);
Console.Clear();
//
//2.6

Console.WriteLine("Veuillez entrez une annee et on va voir si elle est bissextile : ");
int Annee = int.Parse(Console.ReadLine());
if ((Annee % 4 == 0) && (Annee > 1582))
{
    if (Annee % 100 == 0)
    {
        if (Annee % 400 == 0)
        {
            Console.WriteLine("Ceci est une annee bissextile.");
        }
        else
        {
            Console.WriteLine("Ceci n'est pas une annee bissextile.");
        }
    }
    else
    {
        Console.WriteLine("Ceci est une annee bissextile.");
    }

}
else
{
    Console.WriteLine("Ceci n'est pas un annee bissextile. Les annees bissextiles commencent a partir de 1582.");
}
//
//
Thread.Sleep(3000);
Console.Clear();
//
//2.7
//
int verif = 0;
while (verif <=1 || verif >=7)
{
    Console.WriteLine("Ecrivez un nombre entre 1 et 7, puis vous auriez le jour de la semaine : ");
    int NmbSemaine = int.Parse(Console.ReadLine());
    NmbSemaine = verif;
    switch (NmbSemaine)
    {
        case 1:
            Console.WriteLine("Nous sommes dimanche.");
            break;
        case 2:
            Console.WriteLine("Nous sommes lundi.");
            break;
        case 3:
            Console.WriteLine("Nous sommes mardi.");
            break;
        case 4:
            Console.WriteLine("Nous sommes mercredi.");
            break;
        case 5:
            Console.WriteLine("Nous sommes jeudi.");
            break;
        case 6:
            Console.WriteLine("Nous sommes vendredi");
            break;
        case 7:
            Console.WriteLine("Nous sommes samedi");
            break;
        default:
            Console.WriteLine("Veuillez ecrire un nombre valide.");
            verif = 0;
            break;
    }
}