import React from 'react';
import backgroundImage from '../../Assets/BackgroundImages/BackgroundImgCapstone.jpg';
import {
    HomePage,
    FullPage,
    BackgroundImage,
    TopofPage,
    StartStory,
} from './HomeElements';


 function Home() {
    return (
        <>
        <HomePage className="HomePage">
            <FullPage>
                <BackgroundImage src={backgroundImage} className="BackgroundImage"></BackgroundImage>
            </FullPage>
            <TopofPage>
                <StartStory>
                </StartStory>
            </TopofPage>
        </HomePage>
        </>
    )
}

export default Home;
