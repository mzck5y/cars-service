pipeline {
    agent any

    parameters {
        gitParameter name: 'PULL_REQUESTS', 
                     type: 'PT_PULL_REQUEST',
                     defaultValue: '1',
                     sortMode: 'DESCENDING_SMART'
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
}