<# UML Server in Docker #>
docker run -d -p 8080:8080 plantuml/plantuml-server:jetty
start-sleep -Seconds 20
start http://localhost:8080