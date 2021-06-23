pipeline {
    agent any

    parameters {
       string(name: 'PR No.', defaultValue: '' description: '' )
    }

    stages {
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