pipeline {

    agent {
        docker { image 'node:14-alpine' }
    }
    
    stages {
        stage ("SCM Checkout") {
            steps {
                checkout([
                    $class: 'GitSCM', 
                    branches: [
                        [
                            name: '*/master'
                        ]
                    ], 
                    extensions: [], 
                    userRemoteConfigs: [
                        [
                            credentialsId: 'github-credentials', 
                            url: 'https://github.com/mzck5y/cars-service'
                        ]
                    ]
                ])
            }
        }

        stage ("Approval Gate") {
            steps {
                sh "docker --help"
                input 'Your approval is need to send to production'
            }
        }

        stage ("build") {
            steps {
                echo "Building the application..."
            }
        }
        
        stage ("db") {
            steps {
                echo "Updating database..."
            }
        }

        stage ("deploy") {
            steps {
                echo "Deploying application..."
            }
        }

        stage ("test") {
            steps {
                echo "Testing the application..."
            }
        }

        stage("post-deploy") {
            steps {
                echo "Running post deplly stages    "
            }
        }
    }
    post {
        always {
            echo "Pipeline finished send notifications or email."
        }
        success {
            echo "Pipeline success."
        }  
        failure {
            echo "Pipeline fail."
        }
    }
}
