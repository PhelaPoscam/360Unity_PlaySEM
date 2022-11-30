using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Video;
using System.IO;
using System.Threading;



public class Mulsemedia : MonoBehaviour
{

    public string metadata;
    public string playsemIpPortAddress;

    //string metadata01 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><ns2:SEM xmlns:ns2=\"urn:mpeg:mpeg-v:2010:01-SEDL-NS\" xmlns:ns1=\"urn:mpeg:mpeg7:schema:2004\" xmlns:ns3=\"urn:mpeg:mpeg-v:2010:01-SEV-NS\" xmlns:ns4=\"urn:mpeg:mpeg-v:2010:01-CT-NS\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:si=\"urn:mpeg:mpeg21:2003:01-DIA-XSI-NS\" si:timeScale=\"90000\" si:puMode=\"ancestorsDescendants\" si:absTimeScheme=\"mp7t\" xsi:schemaLocation=\"urn:mpeg:mpeg21:2003:01-DIA-XSI-NS http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-21_schema_files/dia-2nd/XSI-2nd.xsd urn:mpeg:mpeg-v:2010:01-SEV-NS http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-V_schema_files/MPEG-V-SEV.xsd urn:mpeg:mpeg7:schema:2004 http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-7_schema_files/mpeg7-v2.xsd\">	<ns2:Effect xsi:type=\"ns3:WindType\" intensity-value=\"50.0\" intensity-range=\"0.0 100.0\" activate=\"true\" si:anchorElement=\"true\" si:pts=\"9000\"/>	<ns2:Effect xsi:type=\"ns3:WindType\" intensity-value=\"100.0\" intensity-range=\"0.0 100.0\" activate=\"true\" si:anchorElement=\"true\" si:pts=\"1890000\"/>	<ns2:Effect xsi:type=\"ns3:ScentType\" intensity-value=\"100.0\" intensity-range=\"0.0 100.0\" activate=\"true\" ns3:scent=\"urn:mpeg:mpeg-v:01-SI-ScentCS-NS:burning_rubber\" si:anchorElement=\"true\" si:pts=\"2430000\"/>	<ns2:Effect xsi:type=\"ns3:WindType\" intensity-value=\"50.0\" intensity-range=\"0.0 100.0\" activate=\"true\" si:anchorElement=\"true\" si:pts=\"2790000\"/>	<ns2:Effect xsi:type=\"ns3:ScentType\" activate=\"false\" si:anchorElement=\"true\" si:pts=\"3330000\"/>	<ns2:Effect xsi:type=\"ns3:ScentType\" intensity-value=\"100.0\" intensity-range=\"0.0 100.0\" activate=\"true\" ns3:scent=\"urn:mpeg:mpeg-v:01-SI-ScentCS-NS:burning_rubber\" si:anchorElement=\"true\" si:pts=\"3870000\"/>	<ns2:Effect xsi:type=\"ns3:ScentType\" activate=\"false\" si:anchorElement=\"true\" si:pts=\"4320000\"/>	<ns2:Effect xsi:type=\"ns3:WindType\" activate=\"false\" si:anchorElement=\"true\" si:pts=\"5310000\"/></ns2:SEM>";
    //string metadata02 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><ns2:SEM xmlns:ns2=\"urn:mpeg:mpeg-v:2010:01-SEDL-NS\" xmlns:ns1=\"urn:mpeg:mpeg7:schema:2004\" xmlns:ns3=\"urn:mpeg:mpeg-v:2010:01-SEV-NS\" xmlns:ns4=\"urn:mpeg:mpeg-v:2010:01-CT-NS\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:si=\"urn:mpeg:mpeg21:2003:01-DIA-XSI-NS\" si:timeScale=\"90000\" si:puMode=\"ancestorsDescendants\" si:absTimeScheme=\"mp7t\" xsi:schemaLocation=\"urn:mpeg:mpeg21:2003:01-DIA-XSI-NS http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-21_schema_files/dia-2nd/XSI-2nd.xsd urn:mpeg:mpeg-v:2010:01-SEV-NS http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-V_schema_files/MPEG-V-SEV.xsd urn:mpeg:mpeg7:schema:2004 http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-7_schema_files/mpeg7-v2.xsd\">		<ns2:Effect xsi:type=\"ns3:ScentType\" intensity-value=\"100.0\" intensity-range=\"0.0 100.0\" activate=\"true\" ns3:scent=\"urn:mpeg:mpeg-v:01-SI-ScentCS-NS:lavender\" si:anchorElement=\"true\" si:pts=\"9000\"/>	<ns2:Effect xsi:type=\"ns3:WindType\" intensity-value=\"30.0\" intensity-range=\"0.0 100.0\" activate=\"true\" si:anchorElement=\"true\" si:pts=\"9000\"/>	<ns2:Effect xsi:type=\"ns3:ScentType\" activate=\"false\" si:anchorElement=\"true\" si:pts=\"5310000\"/>	<ns2:Effect xsi:type=\"ns3:WindType\" activate=\"false\" si:anchorElement=\"true\" si:pts=\"5310000\"/></ns2:SEM>";
    //string metadata03 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><ns2:SEM xmlns:ns2=\"urn:mpeg:mpeg-v:2010:01-SEDL-NS\" xmlns:ns1=\"urn:mpeg:mpeg7:schema:2004\" xmlns:ns3=\"urn:mpeg:mpeg-v:2010:01-SEV-NS\" xmlns:ns4=\"urn:mpeg:mpeg-v:2010:01-CT-NS\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:si=\"urn:mpeg:mpeg21:2003:01-DIA-XSI-NS\" si:timeScale=\"90000\" si:puMode=\"ancestorsDescendants\" si:absTimeScheme=\"mp7t\" xsi:schemaLocation=\"urn:mpeg:mpeg21:2003:01-DIA-XSI-NS http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-21_schema_files/dia-2nd/XSI-2nd.xsd urn:mpeg:mpeg-v:2010:01-SEV-NS http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-V_schema_files/MPEG-V-SEV.xsd urn:mpeg:mpeg7:schema:2004 http://standards.iso.org/ittf/PubliclyAvailableStandards/MPEG-7_schema_files/mpeg7-v2.xsd\">		<ns2:Effect xsi:type=\"ns3:ScentType\" intensity-value=\"100.0\" intensity-range=\"0.0 100.0\" activate=\"true\" ns3:scent=\"urn:mpeg:mpeg-v:01-SI-ScentCS-NS:coffee_cream\" si:anchorElement=\"true\" si:pts=\"9000\"/>	<ns2:Effect xsi:type=\"ns3:WindType\" intensity-value=\"100.0\" intensity-range=\"0.0 100.0\" activate=\"true\" si:anchorElement=\"true\" si:pts=\"450000\"/>	<ns2:Effect xsi:type=\"ns3:WindType\" activate=\"false\" si:anchorElement=\"true\" si:pts=\"540000\"/>	<ns2:Effect xsi:type=\"ns3:ScentType\" activate=\"false\" si:anchorElement=\"true\" si:pts=\"5310000\"/></ns2:SEM>";


    //private WebSocket webSocketConn;

    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
