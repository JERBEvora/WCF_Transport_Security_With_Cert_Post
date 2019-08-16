# WCF_Transport_Security_With_Cert_Post
Source code for my blog (www.jeevora.com) post about WCF Transport Security with Certificate Authentication 
- Validation with Parameterized test (https://www.jeevora.com/2019/08/15/wcf-transport-security-with-certificate-authentication/?preview=true)

This post discusses the use of X.509 certificates for server and client authentication when using transport security especially to intranet communication.

Our service will implement a simple repeated string algorithms. In this scenario, the service is hosted under Internet Information Services (IIS) which is configured with Secure Sockets Layer (SSL) and configured with an SSL certificate to allow clients to verify the identity of the server.

On the other hand, our client is a parameterized test project that will validate the logic of our service. The client is also configured with an X.509 certificate that allows the service to verify the identity of the client. The server’s certificate must be trusted by the client and the client’s certificate must be trusted by the server.
