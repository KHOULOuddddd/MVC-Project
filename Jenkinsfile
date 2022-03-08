pipeline {
    agent any
    triggers {
        githubPush()
    }
    stages {
        stage('Restore packages'){
           steps{
               sh 'dotnet restore MVC Project.sln'
            }
         }
        stage('Clean'){
           steps{
               sh 'dotnet clean MVC Project.sln --configuration Release'
            }
         }
        stage('Build'){
           steps{
               sh 'dotnet build MVC Project.sln --configuration Release --no-restore'
            }
         }
    }
}