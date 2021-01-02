using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendToGoogle : MonoBehaviour
{ 

    public GameObject username;
    public GameObject surname;
    public GameObject yas;
    public GameObject cinsiyet;
    public GameObject dTarih;
    public GameObject dYeri;
    public GameObject yasadigiSehir;
    public GameObject elkullanimi;
    public GameObject gorme;
    public GameObject egitim;
    public GameObject alkolKullanimi;
    public GameObject kahveKullanimi;
    public GameObject cayKullanimi;
    public GameObject tutunKullanimi;
    public GameObject ilacKullanimi;
    public GameObject normalUyku;
    public GameObject dunGecekiUyku;
    public GameObject ruhHali;
    public GameObject bciKullandimi;
    public GameObject saglikSorunu;
    public GameObject duzenliIlac;
    public GameObject suanIlac;
    
    public string Yas;
    public string Name;
    public string Surname;
    public string Cinsiyet;
    public string DTarih;
    public string Dyeri;
    public string YasadigiSehir;
    public string Elkullanimi;
    public string Gorme;
    public string Egitim;
    public string AlkolKullanimi;
    public string KahveKullanimi;
    public string CayKullanimi;
    public string TutunKullanimi;
    public string IlacKullanimi;
    public string NormalUyku;
    public string DunGecekiUyku;
    public string RuhHali;
    public string BCIkullanimi;
    public string SaglikSorunu;
    public string DuzenliIlac;
    public string SuanIlac;


// kullanıcıya ilk etapta form gönderip soruların doldurması için C# dili ve unity arayüzü ile yazılan kodlar
    [SerializeField]

    private string BaseUrl = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdJ3Su3CFZUM5aO_UrOU7sjMJwGvDFi2049wnRrui1_rXzZbw/formResponse";

    IEnumerator Post(string name, string surname, string yas, string cinsiyet, string dogumTarihi, string dogumYeri, string yasadigisehir,string elkullanimi, string gorme,string egitim, string alkolkullanimi
    ,string kahveKullanimi, string cayKullanimi, string tutunKullanimi, string ilacKullanimi, string normalUyku, string dunGecekiUyku, string ruhHali,string bciKullanimi,
    string saglikSorunu,string duzenliIlac,string suankiIlac)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.675230857", name);
        form.AddField("entry.1336543796", surname);
        form.AddField("entry.907041652", yas);
        form.AddField("entry.1710780455", cinsiyet);
        form.AddField("entry.2053521192", dogumTarihi);
        form.AddField("entry.1768872946", dogumYeri);
        form.AddField("entry.769099516", yasadigisehir);
        form.AddField("entry.2066923194", elkullanimi);

        form.AddField("entry.1458465993", gorme);
        form.AddField("entry.1214302185", egitim);
        form.AddField("entry.575636402", alkolkullanimi);

        form.AddField("entry.55413062", kahveKullanimi);
        form.AddField("entry.800355178", cayKullanimi);
        form.AddField("entry.1178937207", tutunKullanimi);
        form.AddField("entry.1660450768", ilacKullanimi);

        form.AddField("entry.3578237", normalUyku);
        form.AddField("entry.665765370", dunGecekiUyku);
        form.AddField("entry.898936522", ruhHali);
        form.AddField("entry.1609836029", bciKullanimi);

        form.AddField("entry.1066818364", saglikSorunu);
        form.AddField("entry.537433168", duzenliIlac);
        form.AddField("entry.1614644211", suankiIlac);


        byte[] rawData = form.data;
        WWW www = new WWW(BaseUrl, rawData);
        yield return www;   
    }

     public void sahne_degis(  int sahne_id)
    {
       SceneManager.LoadScene(sahne_id);
       
    }
    public void Send(){


        Name = username.GetComponent<InputField>().text;
        Surname = surname.GetComponent<InputField>().text;
        Yas = yas.GetComponent<InputField>().text;

        Cinsiyet = cinsiyet.GetComponent<InputField>().text;
        DTarih = dTarih.GetComponent<InputField>().text;
        Dyeri = dYeri.GetComponent<InputField>().text;

        YasadigiSehir = yasadigiSehir.GetComponent<InputField>().text;
        Elkullanimi = elkullanimi.GetComponent<InputField>().text;
        Gorme = gorme.GetComponent<InputField>().text;

        Egitim = egitim.GetComponent<InputField>().text;
        AlkolKullanimi = alkolKullanimi.GetComponent<InputField>().text;
        KahveKullanimi = kahveKullanimi.GetComponent<InputField>().text;

        CayKullanimi = cayKullanimi.GetComponent<InputField>().text;
        TutunKullanimi = tutunKullanimi.GetComponent<InputField>().text;
        IlacKullanimi = ilacKullanimi.GetComponent<InputField>().text;

        NormalUyku = normalUyku.GetComponent<InputField>().text;
        DunGecekiUyku = dunGecekiUyku.GetComponent<InputField>().text;
        RuhHali = ruhHali.GetComponent<InputField>().text;

        BCIkullanimi = bciKullandimi.GetComponent<InputField>().text;   

        SaglikSorunu = saglikSorunu.GetComponent<InputField>().text;
        DuzenliIlac = duzenliIlac.GetComponent<InputField>().text;
        SuanIlac = suanIlac.GetComponent<InputField>().text;
        //StartCoroutine(Post(Name, Surname, Email));
        StartCoroutine(Post(Name, Surname, Yas,Cinsiyet,DTarih,Dyeri,YasadigiSehir,Elkullanimi,Gorme,Egitim,AlkolKullanimi,KahveKullanimi,CayKullanimi,TutunKullanimi,IlacKullanimi,
        NormalUyku,DunGecekiUyku,RuhHali,BCIkullanimi,SaglikSorunu,DuzenliIlac,SuanIlac));
    }

}
