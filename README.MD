docker run --name postgre-credito -p 5432:5432 -e POSTGRES_PASSWORD=mysecretpassword -d postgres

docker build -t liberacao-credito .

docker run -d -p 9090:80 -e ASPNETCORE_ENVIRONMENT='Development' --name liberacao-credito liberacao-credito