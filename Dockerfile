FROM mcr.microsoft.com/dotnet/core/sdk:3.1
COPY Assignment2-Student/ /app/Assignment2-Student
COPY StudentClass/ /app/StudentClass
WORKDIR /app/Assignment2-Student
EXPOSE 8888/tcp
EXPOSE 8889/tcp
CMD [ "dotnet", "run"]