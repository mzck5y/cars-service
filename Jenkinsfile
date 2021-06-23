pipeline {
    agent any
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
}