pipeline {
    agent any
    stages {
        stage('Build') {
            agent {
                docker {
                    image 'mcr.microsoft.com/dotnet/sdk' 
                    args '-p 3000:3000'
                }
            }
            steps {
                sh 'dotnet --version'
            }
        }
    }
}
