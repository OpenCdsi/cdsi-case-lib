namespace OpenCdsi.Cases
{
    public class testcase
    {
        public string CdcTestId { get; init;  } = string.Empty;
        public string? TestcaseName { get; init;  }
        public string? VaccineGroup { get; init;  }
        public string? EvaluationTestType { get; init;  }
        public string? ForecastTestType { get; init;  }
        public DateTime AssessmentDate { get; init;  }
        public testcasePatient? Patient { get; init;  }
        public testcaseEvaluationExpectedResult? Evaluation { get; init;  }
        public testcaseForecastExpectedResult? Forecast { get; init;  }
        public IEnumerable<testcaseVaccineDoseAdministered>? Doses { get; init;  }
        public DateTime DateAdded { get; init;  }
        public DateTime DateUpdated { get; init;  }
        public string? GeneralDescription { get; init;  }
        public string? ChangedInVersion { get; init;  }
        public string? ReasonForChange { get; init;  }
    }
}
