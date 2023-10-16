FROM mysql:latest
ENV MYSQL_DATABASE=typer-db
ENV MYSQL_ROOT_PASSWORD="password"
ENV MYSQL_ROOT_HOST=%

COPY Migrations/*.sql /docker-entrypoint-initdb.d/