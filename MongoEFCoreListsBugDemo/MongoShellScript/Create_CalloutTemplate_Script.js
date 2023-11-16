db.CalloutTemplateDemo.insert(
    {
    	"_id" : ObjectId("654d2e7d9f7bd5fbec3e57b3"),
    	"name" : "Imaginary Callout Template",
    	"inheritFromCallout" : true,
    	"callRounds" : [
    		{
    			"jobQualifiers" : [
    				{
    					"_id" : ObjectId("6502242cc514ff9f2ea4c1a8")
    				},
    				{
    					"_id" : ObjectId("65022447c514ff9f2ea4c1a9")
    				},
    				{
    					"_id" : ObjectId("65022481c514ff9f2ea4c1aa")
    				},
    				{
    					"_id" : ObjectId("65022498c514ff9f2ea4c1ab")
    				}
    			],
    			"isOvertime" : false,
    			"offerOrientedOnly" : true,
    			"genderRequirements" : "F"
    		},
    		{
    			"jobQualifiers" : [
    				{
    					"_id" : ObjectId("6502242cc514ff9f2ea4c1a8")
    				},
    				{
    					"_id" : ObjectId("65022447c514ff9f2ea4c1a9")
    				},
    				{
    					"_id" : ObjectId("65022481c514ff9f2ea4c1aa")
    				}
    			],
    			"isOvertime" : false,
    			"offerOrientedOnly" : false,
    			"genderRequirements" : "F"
    		},
    		{
    			"jobQualifiers" : null,
    			"isOvertime" : true,
    			"offerOrientedOnly" : false,
    			"genderRequirements" : "N"
    		}
    	],
    	"qualifiers" : {
    		"worksiteId" : ObjectId("64e3b0163b105656250fceb8"),
    		"jobClassificationId" : ObjectId("64e3b0163b105656250fcedd"),
    		"jobQualifiers" : [
    			{
    				"_id" : ObjectId("6502242cc514ff9f2ea4c1a8")
    			},
    			{
    				"_id" : ObjectId("65022447c514ff9f2ea4c1a9")
    			},
    			{
    				"_id" : ObjectId("65022481c514ff9f2ea4c1aa")
    			},
    			{
    				"_id" : ObjectId("65022498c514ff9f2ea4c1ab")
    			}
    		],
    		"genderRequirements" : "F"
    	}
    }
)

